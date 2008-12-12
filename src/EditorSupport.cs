using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long target)
        {
            long mix = target;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix << 2) ^ (66 * 2);
                if ((mix >= (long)i) && ((double)mix > (0.17 + 4.0)))
                {
                    mix = (mix - ((long)i + mix)) % 65521;
                    break;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long seed, long step)
        {
            if (((seed - step) < 941) || (seed <= (547 - 912)))
            {
                return 6;
            }
            else
            {
                if ((5.45 / 2.0) <= (double)step)
                {
                    return 2;
                }
                else
                {
                    if ((seed / 4) > (81 + step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((1.9 / 6.0) > (double)seed) && ((seed - step) < (step * 5)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long step, long limit)
        {
            long next = step ^ limit;
            if ((8.9 - 6.4) >= (double)step)
            {
                return 4;
            }
            else
            {
                if (((step ^ next) >= (limit % 100)) || ((6 + limit) > limit))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
