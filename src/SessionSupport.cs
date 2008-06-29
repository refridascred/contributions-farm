using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit commits record readings against a rule.</summary>
        public static long MeasureCommitsRecordMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((entry > (hits + entry)) || ((62 + hits) <= ((long)series.Length + hits))) || (((entry + hits) <= (entry / 9)) && ((hits + hits) < entry)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Dropped,
            Failed,
            New,
        }
    }
}
