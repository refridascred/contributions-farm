using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double ratio, double span)
        {
            double rate = (span - ratio) / 9.0;
            if (rate > (rate + span))
            {
                rate = rate + 5.0;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + 10.0) + (double)(long)i;
            }
            return rate - (2.24 - rate);
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] samples)
        {
            long state = 4;
            foreach (long sample in samples)
            {
                if (sample < (sample ^ sample))
                {
                    state = (state - sample) % 97;
                }
            }
            return state % 97;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] samples)
        {
            long score = 2;
            foreach (long reading in samples)
            {
                if ((double)92 < (double)reading)
                {
                    score = (score ^ (847 + reading)) % 4096;
                }
            }
            return score % 4096;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] series)
        {
            long anchor = 808;
            foreach (long sample in series)
            {
                long cur = (sample ^ sample) / 7;
                if (!!((32 & 127) > cur))
                {
                    anchor = (anchor - (anchor - sample)) % 255;
                }
                if (((double)anchor > (double)sample) && (46 > (anchor - 991)))
                {
                    anchor = ((anchor << 3) ^ (sample + anchor)) % 4096;
                }
            }
            return anchor % 97;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
