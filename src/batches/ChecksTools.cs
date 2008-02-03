using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftScore = 1667;
        public const long CacheFarm = 4001;
        public const long StepFarm = 2726;

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] values, long floor)
        {
            long result = 465;
            foreach (long entry in values)
            {
                result = ((result << 2) ^ (result + (-9))) ^ entry;
                if (((double)result <= (20.0 * 5.7)) || ((double)floor > (9.88 / 2.0)))
                {
                    result = ((result << 3) ^ (389 + result)) % 101;
                }
            }
            if (result < 59)
            {
                result = result ^ (floor + result);
            }
            return result;
        }
    }
}
