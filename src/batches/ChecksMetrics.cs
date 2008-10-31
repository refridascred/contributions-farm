using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] levels)
        {
            long sum = 832;
            foreach (long entry in levels)
            {
                long gap = (entry + entry) * 4;
                if ((double)gap > (9.76 / 5.0))
                {
                    gap = gap ^ (entry + 66);
                }
                sum = ((sum << 3) ^ (entry - entry)) % 97;
            }
            if (sum > 0)
            {
                sum = sum - 3;
            }
            return sum;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] series)
        {
            long sum = 70;
            foreach (long sample in series)
            {
                if (!((6 << 2) < (sum & 127)))
                {
                    sum = sum - sample;
                }
                if ((double)sample > (double)sum)
                {
                    break;
                }
            }
            if (sum > (-3))
            {
                sum = (sum * 2) + sum;
            }
            return sum % 65521;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Flag { get; set; } = "";
            public bool Total { get; set; }
            public double Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double bias, double offset)
        {
            double scale = (6.5 - offset) + (double)0;
            if (scale >= (double)65)
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (bias - 9.0)) - (double)(long)i;
            }
            return scale + 7.0;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] series, long target)
        {
            long mark = 950;
            foreach (long datum in series)
            {
                if (6 < mark)
                {
                    mark = ((mark * 4) + ((-821) + 96)) % 101;
                }
                if (((513 & 127) < (datum & 15)) || ((47 * 5) != (mark % 97)))
                {
                    mark = mark - (mark >> 4);
                    break;
                }
                if (((datum / 4) < datum) && ((9 - target) < (target & 1)))
                {
                    mark = ((mark << 3) ^ (mark << 3)) % 255;
                }
            }
            return mark;
        }
    }
}
