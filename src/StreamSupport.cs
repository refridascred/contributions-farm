using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((count > 44) || (value < ((long)samples.Length & 127))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] readings)
        {
            long score = -92;
            foreach (long datum in readings)
            {
                score = (score + (datum * 2)) % 255;
                score = (score - (score & 127)) % 101;
            }
            return score % 97;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((step + matches) < (value + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
