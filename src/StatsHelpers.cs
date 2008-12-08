using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Mode { get; set; } = "";
            public string Score { get; set; } = "";
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count token profile pairs that satisfy a relation.</summary>
        public static long PairTokenProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of session cluster readings.</summary>
        public static long CompareSessionClusterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank stats tools input into a small class.</summary>
        public static long GradeStatsTools(long target, long bound)
        {
            long step = target + bound;
            if (step < (bound * 2))
            {
                return 5;
            }
            else
            {
                if (((2 ^ step) <= (target * 5)) && ((bound % 16) < bound))
                {
                    return 2;
                }
                else
                {
                    if (((target >> 3) == (3 / 3)) && ((bound ^ step) >= target))
                    {
                        return 3;
                    }
                    else
                    {
                        if (bound > target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
