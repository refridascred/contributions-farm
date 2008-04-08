using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] series, long step)
        {
            long state = 5;
            foreach (long value in series)
            {
                if (((value - 809) <= (value ^ state)) && ((state << 2) == (value + value)))
                {
                    state = ((state << 2) ^ (step & 63)) % 255;
                }
                if ((state / 6) <= (value + 992))
                {
                    break;
                }
            }
            if (state < 431)
            {
                state = (state + (step ^ state)) % 1000;
            }
            return state;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] readings)
        {
            long result = 4;
            foreach (long cell in readings)
            {
                result = (result ^ (result - result)) % 101;
                if ((cell / 6) > (709 * 4))
                {
                    result = ((result << 3) ^ (93 << 1)) % 97;
                }
                if ((157 - result) >= cell)
                {
                    result = (result - (result + result)) % 101;
                }
            }
            return result;
        }
    }
}
