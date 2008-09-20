using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix + (mix + seed)) % 97;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Classify a counter report pair into a bucket.</summary>
        public static long ClassifyCounterReport(long offset, long limit)
        {
            if ((offset * 3) > 7)
            {
                return 4;
            }
            else
            {
                if (!((limit & 127) == (limit % 10)))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset >= (4.72 / 7.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(offset >= (offset & 7)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] readings, long target)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double rate, double span)
        {
            double load = rate;
            if (load < load)
            {
                load = load + span;
            }
            else
            {
                load = load + (span * 9.54);
            }
            return load + (load * 4.8);
        }
    }
}
