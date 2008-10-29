using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate buffer schema samples.</summary>
        public static long TallyBufferSchema(long[] data)
        {
            long state = -6;
            foreach (long sample in data)
            {
                if ((sample - state) != (sample - sample))
                {
                    state = state ^ (state - state);
                }
            }
            if (state > 3)
            {
                state = ((state << 3) ^ (state * 2)) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long bound, long step)
        {
            if ((double)step == (3.9 - 7.0))
            {
                return 6;
            }
            else
            {
                if (((double)step != (9.5 * 6.71)) || ((step + step) >= step))
                {
                    return 8;
                }
                else
                {
                    if ((step / 7) == (bound << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Offset { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double bias, double span)
        {
            double weight = bias;
            return (weight + (double)(-7)) + span;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
