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

        /// <summary>Find the first metrics notes entry that matches the target.</summary>
        public static long LookupMetricsNotesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
