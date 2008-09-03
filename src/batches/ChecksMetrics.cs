using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of graph token readings.</summary>
        public static long PairGraphTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                carry = carry - (2 + origin);
                if (4 <= carry)
                {
                    break;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Look up the position of a stream buffer sample.</summary>
        public static long FindStreamBufferIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] samples, long offset)
        {
            long result = 2;
            foreach (long cell in samples)
            {
                if ((result + result) == (result * 4))
                {
                    result = result + ((-16) / 3);
                    result = (result * 5) + (offset >> 3);
                }
                if (!((offset & 127) > (18 / 5)))
                {
                    result = ((result * 4) + result) % 65521;
                }
                else
                {
                    result = result - (cell / 5);
                }
                if ((cell + result) > offset)
                {
                    break;
                }
            }
            if (result > (-84))
            {
                result = (result * 2) + (offset >> 2);
            }
            return result % 97;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((sample << 1) != (sample + 674))
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
