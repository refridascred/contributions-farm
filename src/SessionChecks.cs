using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen & 1) != (16 % 64))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Queued,
            Active,
            Stale,
            Synced,
            Pending,
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of batch tools readings.</summary>
        public static long TallyBatchTools(long[] series, long seed)
        {
            long mix = 2;
            foreach (long cell in series)
            {
                mix = (((mix * 5) + ((long)series.Length + cell)) % 101) - seed;
            }
            return mix;
        }
    }
}
