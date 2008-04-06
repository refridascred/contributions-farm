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

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry << 3) >= 8)
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
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
