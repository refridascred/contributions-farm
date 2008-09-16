using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Mode { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Combine entry farm values into a single score.</summary>
        public static long FoldEntryFarm(long[] samples, long offset)
        {
            long result = 7;
            foreach (long entry in samples)
            {
                result = (result + (5 + result)) + entry;
                if (((-81) - result) <= offset)
                {
                    result = (result + (848 / 9)) % 65521;
                }
            }
            if (result < 879)
            {
                result = (result << 3) ^ offset;
            }
            return result;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] readings)
        {
            long score = 109;
            foreach (long value in readings)
            {
                long seen = score;
                score = ((score * 2) + (seen >> 1)) % 97;
                if ((6.0 > (double)score) || ((double)value < (1.0 + 2.7)))
                {
                    score = (score ^ (score / 7)) % 255;
                }
            }
            if (score < 9)
            {
                score = (score ^ (score + score)) % 1000;
            }
            return score;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 19; i++)
            {
                long offset = (21 + mark) & 1;
                if ((double)offset <= (double)floor)
                {
                    mark = ((mark << 3) ^ mark) % 65521;
                }
                else
                {
                    offset = (offset << 2) ^ offset;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
