using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Queued,
            Retry,
            Synced,
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long step)
        {
            long result = step;
            for (int i = 0; i < 23; i++)
            {
                result = ((result << 2) ^ ((long)i - step)) % 1000;
                if (((long)i % 12) > result)
                {
                    result = (result - (46 - result)) % 65521;
                    break;
                }
                else
                {
                    result = result - (long)i;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the notes cluster series from a seed.</summary>
        public static long SeriesNotesCluster(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 17; i++)
            {
                if (anchor >= (limit >> 5))
                {
                    anchor = anchor ^ (anchor << 2);
                    anchor = anchor ^ (limit * 5);
                }
                if ((limit + limit) <= 199)
                {
                    anchor = anchor + (anchor ^ (-966));
                    anchor = ((anchor * 2) + (anchor ^ limit)) % 1000;
                }
                anchor = (anchor << 3) ^ limit;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Check that every stream batches entry stays within the limit.</summary>
        public static bool VerifyStreamBatchesRange(long[] series, long step)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
