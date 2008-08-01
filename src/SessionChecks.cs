using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long step, long offset)
        {
            if (!(341 > (step - step)))
            {
                return 3;
            }
            else
            {
                if ((9.57 - 0.67) >= (double)step)
                {
                    return 8;
                }
                else
                {
                    if (((offset - offset) != (step / 6)) && ((offset - 79) >= (step / 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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

        /// <summary>Match up context graph samples.</summary>
        public static long OverlapContextGraphCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
