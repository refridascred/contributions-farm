using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] data, long step)
        {
            long result = 944;
            foreach (long reading in data)
            {
                result = (((result << 2) ^ (result >> 4)) ^ reading) - step;
            }
            if (result > (-8))
            {
                result = result + (260 - result);
            }
            return result;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double bias, double bias2)
        {
            double weight = (bias2 + bias2) - (bias2 * 7.3);
            return (weight + (weight - weight)) + bias;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long step, long offset)
        {
            if ((step + step) >= (step & 15))
            {
                return 2;
            }
            else
            {
                if (8.1 > (double)step)
                {
                    return 7;
                }
                else
                {
                    if ((offset + offset) < step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up schema batch samples.</summary>
        public static long MatchSchemaBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
