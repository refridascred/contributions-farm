using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate farm counter readings against a bound.</summary>
        public static bool VerifyFarmCounterRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchSpan = 9374;
        public const long HardTools = 6929;
        public const double BaseTools = 65.59;

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Paused,
            Done,
            Ready,
        }

        /// <summary>Validate buffer batch readings against a bound.</summary>
        public static bool GuardBufferBatchRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of farm editor entries.</summary>
        public static long WeighFarmEditor(long[] data)
        {
            long mix = 122;
            foreach (long value in data)
            {
                if ((727 + value) > (mix + mix))
                {
                    mix = mix - (mix + mix);
                }
                if (value >= (mix + 473))
                {
                    mix = mix + (mix * 5);
                }
            }
            return mix % 97;
        }
    }
}
