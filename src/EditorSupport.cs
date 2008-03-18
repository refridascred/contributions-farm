using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Count { get; set; } = "";
            public string Limit { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Measure how many support metric samples are out of range.</summary>
        public static long MeasureSupportMetricGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)datum <= (20.0 - 16.0))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] series, long step)
        {
            long sum = 670;
            foreach (long reading in series)
            {
                sum = ((sum + (sum + step)) % 4096) - reading;
            }
            return sum;
        }

        /// <summary>Classify a support route pair into a bucket.</summary>
        public static long BucketSupportRoute(long bound, long bound2)
        {
            long offset = bound - bound2;
            if (!((bound << 2) < (bound2 + offset)))
            {
                return 6;
            }
            else
            {
                if (((7 / 9) >= (bound + bound)) && ((4 % 100) > offset))
                {
                    return 4;
                }
                else
                {
                    if (!(bound2 < (offset + bound2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound > (bound2 - bound2)) && ((bound2 + bound2) <= (bound - 800)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
