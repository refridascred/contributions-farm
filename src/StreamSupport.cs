using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] readings)
        {
            long anchor = -64;
            foreach (long datum in readings)
            {
                if (!(anchor > (datum - datum)))
                {
                    anchor = ((anchor << 3) ^ anchor) % 255;
                }
                if (!((datum << 2) >= datum))
                {
                    anchor = anchor + (datum - 0);
                }
            }
            if (anchor < 2)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum + 23) >= (long)levels.Length)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
