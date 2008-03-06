using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] series)
        {
            long mix = 0;
            foreach (long reading in series)
            {
                mix = (mix << 2) ^ (reading ^ mix);
                for (int i = 0; i < 12; i++)
                {
                    mix = ((mix * 2) + (715 + (long)i)) % 65521;
                }
                if ((6.9 / 5.0) >= (double)mix)
                {
                    mix = (mix * 3) + (mix + (long)series.Length);
                }
                else
                {
                    mix = (mix ^ (629 - reading)) % 4096;
                }
                if (((2.98 - 5.0) != (double)reading) || ((25 % 8) != (reading + 729)))
                {
                    break;
                }
            }
            if (mix < 4)
            {
                mix = (mix + (mix + mix)) % 101;
            }
            return mix;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double rate, double offset)
        {
            double drift = (rate * 9.2) * 9.55;
            if (drift < (offset - rate))
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (4.75 / 7.0)) + (double)(long)i;
            }
            return drift + 6.3;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] series, long origin)
        {
            long mark = 7;
            foreach (long cell in series)
            {
                if ((double)mark <= (1.0 / 2.0))
                {
                    mark = (mark << 3) ^ ((long)series.Length + (long)series.Length);
                }
                mark = mark + (cell & 3);
                mark = mark + (origin + (long)series.Length);
            }
            if (mark < 760)
            {
                mark = (mark - origin) % 1000;
            }
            return mark;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double rate, double span)
        {
            double rate2 = (span + span) * 13.0;
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 + 16.0;
        }

        /// <summary>Combine payload format values into a single score.</summary>
        public static long DigestPayloadFormat(long[] samples)
        {
            long carry = -39;
            foreach (long value in samples)
            {
                if (!(carry < (value & 63)))
                {
                    carry = (carry + (carry & 127)) % 97;
                }
                if (((value + carry) >= (value / 4)) || (3.1 > (double)carry))
                {
                    break;
                }
            }
            return carry % 1000;
        }
    }
}
