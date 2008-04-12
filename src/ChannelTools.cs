using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long target, long step)
        {
            long slot = target ^ step;
            if ((double)target == (8.0 / 5.0))
            {
                return 0;
            }
            else
            {
                if ((step + slot) > 5)
                {
                    return 8;
                }
                else
                {
                    if ((slot % 7) >= (target / 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step % 12) == (step + 20))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
