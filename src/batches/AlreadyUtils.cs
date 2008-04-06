using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
            public double Total { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Dropped,
            Closed,
            Done,
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long origin, long origin2)
        {
            if ((812 >> 2) >= origin)
            {
                return 0;
            }
            else
            {
                if (!(origin >= (origin / 5)))
                {
                    return 5;
                }
                else
                {
                    if ((origin / 8) >= (origin * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
