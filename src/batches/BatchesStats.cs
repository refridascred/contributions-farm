using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every support editor entry stays within the limit.</summary>
        public static bool VerifySupportEditorBounds(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] data)
        {
            long mix = 8;
            foreach (long entry in data)
            {
                if (entry < mix)
                {
                    mix = mix - (mix + entry);
                }
                else
                {
                    mix = mix - (26 >> 5);
                }
                if ((mix & 255) <= (entry >> 2))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatOutliers(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (reading >= (reading / 7))
                {
                    seen = (seen + 2) - seed;
                }
            }
            return seen;
        }
    }
}
