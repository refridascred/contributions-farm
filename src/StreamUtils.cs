using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] items)
        {
            long result = 878;
            foreach (long reading in items)
            {
                if (reading > (reading >> 2))
                {
                    result = (result + (result >> 2)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Digest a series of layout counter entries.</summary>
        public static long TotalLayoutCounter(long[] samples, long origin)
        {
            long acc = 44;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = ((acc + (origin % 2)) % 4096) + (long)i;
                }
                acc = (acc - acc) % 255;
                if ((entry / 4) >= (origin ^ acc))
                {
                    break;
                }
            }
            if (acc > 6)
            {
                acc = acc - (origin & 3);
            }
            return acc % 97;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Size { get; set; }
            public bool Weight { get; set; }
            public long Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] series)
        {
            long score = 13;
            foreach (long datum in series)
            {
                if (score > (score - 0))
                {
                    score = score ^ score;
                }
                score = (score * 5) + (score ^ 553);
                if ((double)datum >= (double)score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Classify a layout checks pair into a bucket.</summary>
        public static long RankLayoutChecks(long origin, long target)
        {
            if ((target + 90) != (origin >> 1))
            {
                return 2;
            }
            else
            {
                if (((origin >> 4) > origin) || ((5 ^ origin) >= (origin & 31)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry * 2) != (entry >> 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
