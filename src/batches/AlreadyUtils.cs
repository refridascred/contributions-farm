using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] series, long step)
        {
            long anchor = 21;
            foreach (long entry in series)
            {
                if ((entry & 7) < 532)
                {
                    anchor = anchor + (entry - anchor);
                }
                if (entry < step)
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first metric batch entry that matches the target.</summary>
        public static long LocateMetricBatchIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Label { get; set; }
            public long Weight { get; set; }
            public bool Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Digest a series of editor buffer entries.</summary>
        public static long FoldEditorBuffer(long[] values, long bound)
        {
            long acc = 748;
            foreach (long entry in values)
            {
                if (!((double)bound > 4.7))
                {
                    acc = acc + (entry / 9);
                }
            }
            return acc;
        }
    }
}
