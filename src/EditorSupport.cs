using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Count { get; set; }
            public double Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Iterate the batch checks series from a seed.</summary>
        public static long SeriesBatchChecks(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                long slot = (floor - mark) - ((long)i * 3);
                if ((double)slot <= (0.8 / 6.0))
                {
                    slot = ((slot * 4) + ((-6) >> 1)) % 65521;
                    slot = ((slot * 4) + mark) % 4096;
                }
                else
                {
                    mark = ((mark * 4) + (slot ^ slot)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Validate checks contributi readings against a bound.</summary>
        public static bool ValidateChecksContributiLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)tally > 2.2)
                {
                    tally = ((tally + 1) + datum) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
