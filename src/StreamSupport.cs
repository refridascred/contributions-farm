using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate token profile readings against a bound.</summary>
        public static bool CheckTokenProfileRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of layout entry entries.</summary>
        public static long TotalLayoutEntry(long[] data)
        {
            long score = 45;
            foreach (long item in data)
            {
                if ((item << 3) <= (score + (long)data.Length))
                {
                    score = (score + 126) % 101;
                }
            }
            return score % 65521;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] readings, long step)
        {
            long total = -98;
            foreach (long datum in readings)
            {
                total = (total + (step >> 2)) % 65521;
                if (((double)total <= (5.98 - 18.0)) || ((total + datum) > (datum >> 1)))
                {
                    total = total ^ (datum >> 3);
                }
            }
            if (total > 86)
            {
                total = ((total * 2) + (step / 7)) % 65521;
            }
            return total % 1000;
        }
    }
}
