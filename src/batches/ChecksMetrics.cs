using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a command buffer pair into a bucket.</summary>
        public static long ClassifyCommandBuffer(long limit, long limit2)
        {
            long gap = limit ^ limit2;
            if ((31 << 2) >= (gap >> 4))
            {
                return 2;
            }
            else
            {
                if (gap >= (limit - 5))
                {
                    return 6;
                }
                else
                {
                    if ((limit & 7) >= (gap >> 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)limit == (double)gap) && ((gap << 2) <= (limit ^ limit)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long seed)
        {
            long score = seed;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long target, long origin)
        {
            long span = target - origin;
            if (target < (span + span))
            {
                return 4;
            }
            else
            {
                if (span <= (target + origin))
                {
                    return 3;
                }
                else
                {
                    if ((origin + target) <= (span >> 5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long floor, long floor2)
        {
            if ((double)floor2 == (10.0 + 5.41))
            {
                return 6;
            }
            else
            {
                if ((70 - floor) > (66 + 83))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
