using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] data, long limit)
        {
            long score = 35;
            foreach (long item in data)
            {
                score = (score - item) + limit;
            }
            return score;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstLevel = 1645;
        public const string IdleAlready = "alpha";
        public const double BatchAlready = 59.23;
        public const double MaxAlready = 86.1;

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
