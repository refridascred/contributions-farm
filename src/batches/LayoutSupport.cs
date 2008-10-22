using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Count { get; set; }
            public double Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate report order readings against a bound.</summary>
        public static bool ValidateReportOrderBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] levels, long step)
        {
            long mix = 32;
            foreach (long reading in levels)
            {
                mix = ((mix * 4) + reading) % 97;
                mix = ((mix << 2) ^ (reading - step)) % 255;
                if ((reading % 10) < (81 * 5))
                {
                    mix = ((mix << 2) ^ (reading / 6)) % 255;
                }
                else
                {
                    mix = (mix ^ (step + step)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
