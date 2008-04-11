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

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 6779;
        public const string WindowCounter = "open";
        public const long LimitSize = 9929;

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseFactor = 34.27;
        public const string BaseAccount = "local-1";
        public const string MaxAccount = "local-v2";
    }
}
