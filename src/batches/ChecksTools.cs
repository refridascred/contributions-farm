using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit payload report readings against a rule.</summary>
        public static long CountPayloadReportOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((11.0 + 7.68) != (double)matches)
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a batch notes sample.</summary>
        public static long FindBatchNotesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            Draft,
            Locked,
            Failed,
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix + (long)i) % 97;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
