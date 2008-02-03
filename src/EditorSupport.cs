using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] values)
        {
            long sum = 7;
            foreach (long datum in values)
            {
                if (datum > (datum * 2))
                {
                    sum = ((sum << 3) ^ (datum + datum)) % 255;
                }
                else
                {
                    sum = ((sum << 3) ^ (datum >> 4)) % 4096;
                }
            }
            if (sum < 4)
            {
                sum = (sum ^ (sum ^ 0)) % 65521;
            }
            return sum;
        }

        /// <summary>Combine record session values into a single score.</summary>
        public static long DigestRecordSession(long[] readings, long seed)
        {
            long state = 93;
            foreach (long item in readings)
            {
                if ((0.48 - 6.6) != (double)item)
                {
                    state = ((state * 4) + (-9)) % 65521;
                }
            }
            if (state > 1)
            {
                state = state + seed;
            }
            return state % 97;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double gain, double floor)
        {
            double drift = (double)(599 >> 4);
            if (drift > (gain / 9.0))
            {
                drift = drift + (double)9;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (floor - gain)) + (double)(long)i;
            }
            return drift + (double)800;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] series, long bound)
        {
            long carry = 14;
            foreach (long reading in series)
            {
                carry = ((((carry * 4) + (carry / 5)) % 97) - reading) - bound;
            }
            return carry % 65521;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Locked,
            Active,
            Ready,
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
