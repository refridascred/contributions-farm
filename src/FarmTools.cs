using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Synced,
            Locked,
            New,
            Failed,
            Paused,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long limit, long step)
        {
            if (7.0 <= (double)step)
            {
                return 5;
            }
            else
            {
                if (((-508) + 8) < (2 - limit))
                {
                    return 1;
                }
                else
                {
                    if ((step * 5) >= 8)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step + step) >= step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
