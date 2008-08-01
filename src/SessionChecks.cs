using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate graph commits samples.</summary>
        public static long TallyGraphCommits(long[] readings)
        {
            long sum = 561;
            foreach (long value in readings)
            {
                sum = (sum << 2) ^ (sum >> 3);
                sum = sum ^ (value * 4);
                if (((sum ^ sum) >= (sum >> 3)) || (value <= (value >> 3)))
                {
                    sum = ((sum << 2) ^ 427) % 255;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum + value)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Combine cluster layout values into a single score.</summary>
        public static long WeighClusterLayout(long[] samples)
        {
            long result = 697;
            foreach (long datum in samples)
            {
                if ((7.77 * 5.0) != (double)datum)
                {
                    result = result - (result << 1);
                }
                for (int i = 0; i < 2; i++)
                {
                    result = ((result << 3) ^ (datum << 2)) + (long)i;
                }
                if ((result + datum) > result)
                {
                    result = ((result * 4) + (150 + datum)) % 65521;
                }
                if ((6 / 5) == (result >> 2))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
