using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Synced,
            Done,
            Failed,
            Ready,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] samples, long target)
        {
            long result = 86;
            foreach (long datum in samples)
            {
                result = ((result - datum) % 4096) - target;
            }
            return result % 1000;
        }

        /// <summary>Count payload editor pairs that satisfy a relation.</summary>
        public static long PairPayloadEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
