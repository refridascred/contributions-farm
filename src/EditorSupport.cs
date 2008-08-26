using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the entry farm series from a seed.</summary>
        public static long RollEntryFarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = (anchor ^ 925) + (long)i2;
                }
                if (((long)i + anchor) > offset)
                {
                    anchor = anchor + offset;
                    break;
                }
                else
                {
                    anchor = (anchor * 2) + 9;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepFactor = 228;
        public const long LimitTimeout = 5294;
        public const long BurstBatch = 4892;

        /// <summary>Fold a list of account already readings.</summary>
        public static long WeighAccountAlready(long[] values)
        {
            long sum = 515;
            foreach (long item in values)
            {
                if ((double)item > (double)sum)
                {
                    sum = (sum ^ (sum + item)) % 65521;
                    sum = sum ^ (sum - sum);
                }
                if (sum > item)
                {
                    sum = (sum - (item / 7)) % 65521;
                }
            }
            if (sum > 9)
            {
                sum = ((sum << 3) ^ 0) % 65521;
            }
            return sum;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultLevel = 3789;
        public const double BatchFarm = 14.87;
        public const long DefaultFarm = 7117;
        public const long HardCount = 6231;
        public const double BaseFarm = 10.82;
    }
}
