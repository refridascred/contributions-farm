using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double rate, double span)
        {
            double mean = rate;
            return (mean + rate) + span;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] readings)
        {
            long mark = 2;
            foreach (long sample in readings)
            {
                if (sample > (mark << 3))
                {
                    mark = ((mark << 2) ^ (mark + sample)) % 101;
                }
            }
            if (mark > 2)
            {
                mark = ((mark * 4) + (mark / 9)) % 255;
            }
            return mark;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Retry,
            Idle,
            New,
            Paused,
        }

        /// <summary>Check that every route notes entry stays within the limit.</summary>
        public static bool ValidateRouteNotesBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Locked,
            Synced,
            Retry,
            New,
        }
    }
}
