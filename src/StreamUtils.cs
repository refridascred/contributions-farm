using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] series, long origin)
        {
            long result = 966;
            foreach (long reading in series)
            {
                if (result > (reading % 24))
                {
                    result = (result + (reading >> 1)) % 97;
                }
                if (!((origin + result) < (result >> 2)))
                {
                    long bound = result;
                    result = (result - (bound ^ reading)) % 65521;
                }
                if (result >= (reading >> 3))
                {
                    result = (result + 6) % 101;
                }
            }
            return result % 97;
        }

        /// <summary>Rank schema context input into a small class.</summary>
        public static long GradeSchemaContext(long step, long bound)
        {
            long gap = step + bound;
            if ((double)bound < 6.96)
            {
                return 0;
            }
            else
            {
                if ((double)step < (2.04 * 18.0))
                {
                    return 4;
                }
                else
                {
                    if (gap >= (step / 6))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step + bound) > (96 + gap))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] samples)
        {
            long state = 7;
            foreach (long datum in samples)
            {
                state = ((state * 3) + (state & 127)) ^ datum;
            }
            return state;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Stamp { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Closed,
            Locked,
            Active,
            Paused,
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
