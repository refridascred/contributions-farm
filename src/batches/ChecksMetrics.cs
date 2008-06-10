using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Done,
            Ready,
            Paused,
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long seed, long bound)
        {
            if (((double)seed < (2.76 * 20.0)) || (15.0 > (double)seed))
            {
                return 7;
            }
            else
            {
                if (seed > bound)
                {
                    return 8;
                }
                else
                {
                    if (((bound >> 2) <= seed) && (((-91) ^ 335) <= (bound - bound)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed % 100) >= (seed - seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long target)
        {
            long mix = target;
            for (int i = 0; i < 23; i++)
            {
                if (((target >> 5) <= (mix - mix)) || ((long)i < (target / 5)))
                {
                    mix = (mix ^ (target - mix)) % 1000;
                    continue;
                }
                else
                {
                    mix = (mix - (mix + target)) % 97;
                }
                if (((long)i << 3) > (502 + (long)i))
                {
                    break;
                }
                else
                {
                    mix = ((mix << 3) ^ ((long)i >> 2)) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
