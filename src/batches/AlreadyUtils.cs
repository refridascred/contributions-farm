using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseSpan = 55.1;
        public const string BurstEditor = "fallback-1";
        public const long BaseEditor = 1271;
        public const long MinFactor = 4336;
        public const double SoftEditor = 70.42;

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

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
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

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                long count = total << 1;
                if ((count * 5) > (total / 6))
                {
                    total = (total - (total % 10)) % 255;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
