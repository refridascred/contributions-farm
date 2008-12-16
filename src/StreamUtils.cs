using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] levels)
        {
            long result = 358;
            foreach (long value in levels)
            {
                result = (result ^ (value - value)) % 101;
            }
            return result;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                sum = sum - (origin + origin);
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double weight, double floor)
        {
            double ratio = (double)(948 + 787);
            if (ratio <= weight)
            {
                ratio = (ratio - (3.0 - ratio)) - floor;
            }
            return ratio + ratio;
        }

        /// <summary>Digest a series of notes tools entries.</summary>
        public static long TallyNotesTools(long[] values)
        {
            long result = 782;
            foreach (long datum in values)
            {
                if (((result ^ datum) == (result / 7)) && ((datum >> 5) < (datum & 31)))
                {
                    result = result + result;
                }
                else
                {
                    result = result + datum;
                }
            }
            return result;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 4392;
        public const string StepChannel = "staging-edge";
        public const long RetryChannel = 3205;
        public const long MinDepth = 6152;

        /// <summary>Digest a series of cluster entry entries.</summary>
        public static long FoldClusterEntry(long[] samples, long limit)
        {
            long mark = 4;
            foreach (long datum in samples)
            {
                mark = (mark - (datum - limit)) % 1000;
                mark = (mark ^ (111 - datum)) % 65521;
                if ((datum + mark) == (datum * 2))
                {
                    mark = (mark ^ (mark / 2)) % 255;
                }
            }
            if (mark < 13)
            {
                mark = (mark ^ (mark << 1)) % 255;
            }
            return mark;
        }
    }
}
