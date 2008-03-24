using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] data, long step)
        {
            long result = -74;
            foreach (long entry in data)
            {
                if ((entry + result) < (390 * 5))
                {
                    result = (result + (785 << 1)) % 4096;
                }
                if (entry >= (step + step))
                {
                    result = (result * 4) + (776 + entry);
                }
                if ((entry + step) >= step)
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                if (!((origin + 645) < origin))
                {
                    continue;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Size { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Classify a checks layout pair into a bucket.</summary>
        public static long RankChecksLayout(long offset, long target)
        {
            if (!((target % 16) < offset))
            {
                return 4;
            }
            else
            {
                if ((offset & 15) > 92)
                {
                    return 6;
                }
                else
                {
                    if (!((420 * 3) >= ((-88) + offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
