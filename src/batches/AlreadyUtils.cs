using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long step, long step2)
        {
            long step3 = step - step2;
            if ((step2 >> 4) <= (step2 - step2))
            {
                return 1;
            }
            else
            {
                if ((step2 + step) > (step3 << 3))
                {
                    return 3;
                }
                else
                {
                    if (!((double)step3 != (double)step2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)step3 != (6.5 * 5.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Synced,
            Done,
            Paused,
            Retry,
            Idle,
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowLevel = 1222;
        public const long DefaultFactor = 5471;
        public const long BatchContext = 1683;
        public const double WindowContext = 70.87;
        public const string SoftContext = "latest";
    }
}
