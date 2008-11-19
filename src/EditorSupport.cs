using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 12; i++)
            {
                mark = mark + mark;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = mix - (mix + mix);
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchEntry = 47.94;
        public const double CacheEntry = 69.99;
        public const long IdleFactor = 2864;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Stale,
            Synced,
            Active,
            Paused,
            Locked,
        }

        /// <summary>Validate buffer route readings against a bound.</summary>
        public static bool VerifyBufferRouteRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
