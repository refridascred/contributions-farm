using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a graph schema reading by value.</summary>
        public static long FindGraphSchemaIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!(6 >= ((-7) + datum)) || ((datum % 97) >= (65 / 7)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Paused,
            Draft,
            Idle,
            Done,
            Queued,
        }
    }
}
