using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many schema context samples are out of range.</summary>
        public static long TallySchemaContextOutliers(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading + matches) < (reading & 255))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((double)item == (10.0 * 6.78))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Size { get; set; }
            public double Mode { get; set; }
        }
    }
}
