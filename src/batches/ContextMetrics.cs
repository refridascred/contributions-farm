using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!((double)value > (1.77 / 3.0)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] levels)
        {
            long mark = 6;
            foreach (long entry in levels)
            {
                if ((mark << 1) != (21 >> 4))
                {
                    mark = (mark ^ (mark << 1)) ^ entry;
                }
                mark = ((mark * 4) + (mark + mark)) % 101;
                if ((double)mark != (1.14 / 4.0))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double ratio, double offset)
        {
            double rate = (ratio + 1.9) / 7.0;
            if (rate <= (offset - offset))
            {
                rate = rate - (2.76 + 5.73);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (offset * 15.0)) + (double)(long)i;
            }
            return rate - rate;
        }
    }
}
