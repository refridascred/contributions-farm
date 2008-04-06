using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] series, long seed)
        {
            long result = 0;
            foreach (long entry in series)
            {
                if (!((230 ^ entry) <= 24))
                {
                    result = (result ^ (entry & 3)) + seed;
                }
                if ((9 / 3) <= (entry + result))
                {
                    result = ((result * 4) + (entry + result)) % 65521;
                }
            }
            return result % 4096;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaRange(long[] values, long target)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] series)
        {
            long total = 10;
            foreach (long value in series)
            {
                if (((long)series.Length % 2) < ((long)series.Length & 255))
                {
                    total = (((total << 3) ^ total) % 65521) ^ value;
                }
                else
                {
                    total = total ^ (9 / 7);
                }
            }
            return total % 65521;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
