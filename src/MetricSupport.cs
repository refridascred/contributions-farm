using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long limit)
        {
            long total = limit;
            for (int i = 0; i < 22; i++)
            {
                total = ((total << 3) ^ (271 & 1)) % 97;
                if ((9.89 / 5.0) >= (double)total)
                {
                    total = total ^ (long)i;
                    break;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = ((total - (total + (long)i)) % 255) + (long)i2;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] series)
        {
            long carry = 75;
            foreach (long item in series)
            {
                carry = ((carry - 81) % 97) ^ item;
                carry = (carry - (4 / 7)) % 4096;
            }
            if (carry < 2)
            {
                carry = (carry + ((long)series.Length - carry)) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry + matches) >= ((long)data.Length + entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
