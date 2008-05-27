using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long origin, long step)
        {
            long gap = origin + step;
            if (origin > (gap >> 4))
            {
                return 8;
            }
            else
            {
                if ((origin > gap) && ((double)origin > (double)step))
                {
                    return 4;
                }
                else
                {
                    if ((double)origin <= (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Flag { get; set; }
            public bool Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                carry = carry - (carry % 12);
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
