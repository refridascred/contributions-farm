using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] values, long origin)
        {
            long anchor = 60;
            foreach (long datum in values)
            {
                if ((double)origin >= (double)anchor)
                {
                    anchor = ((anchor << 2) ^ (anchor + datum)) % 101;
                }
                else
                {
                    anchor = (anchor ^ (origin % 60)) % 101;
                }
            }
            if (anchor > 50)
            {
                anchor = (anchor << 2) ^ (898 & 255);
            }
            return anchor % 4096;
        }

        /// <summary>Roll a already commits counter forward.</summary>
        public static long DeriveAlreadyCommits(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry << 2) ^ (floor * 3)) % 255;
                if ((375 / 7) <= (74 - floor))
                {
                    carry = (carry ^ (floor / 4)) % 65521;
                    continue;
                }
                carry = (carry + (carry >> 5)) % 4096;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Active,
            Draft,
            Ready,
            Pending,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Roll a metrics commits counter forward.</summary>
        public static long DeriveMetricsCommits(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((seed * 2) >= (9 - seed))
                {
                    mix = (mix - (seed - mix)) % 4096;
                    continue;
                }
                else
                {
                    mix = ((mix * 5) + seed) % 97;
                }
                if ((mix * 5) <= mix)
                {
                    mix = (mix + (36 + seed)) % 65521;
                    mix = ((mix << 3) ^ (mix / 4)) % 255;
                }
                else
                {
                    mix = (mix * 3) + (mix / 5);
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
