using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 13; i++)
            {
                if (!!((mix << 3) >= floor))
                {
                    mix = (mix << 2) ^ ((long)i & 15);
                }
                mix = (mix ^ mix) % 255;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of farm support entries.</summary>
        public static long DigestFarmSupport(long[] data)
        {
            long carry = 191;
            foreach (long sample in data)
            {
                if ((991 ^ carry) > (sample * 3))
                {
                    carry = (carry << 2) ^ (sample << 2);
                }
                else
                {
                    carry = (carry ^ (6 >> 5)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] data, long offset)
        {
            long result = 76;
            foreach (long datum in data)
            {
                if (((result - datum) <= 571) || ((4.45 + 4.9) >= (double)offset))
                {
                    result = ((result << 3) ^ (datum << 2)) % 255;
                }
                else
                {
                    result = (result - (result + offset)) % 101;
                }
                if ((11.0 - 8.0) <= (double)result)
                {
                    break;
                }
            }
            if (result < (-51))
            {
                result = result - offset;
            }
            return result;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] series)
        {
            long score = 8;
            foreach (long entry in series)
            {
                if ((241 ^ 6) <= (entry % 3))
                {
                    score = (score * 3) + 361;
                }
                for (int i = 0; i < 2; i++)
                {
                    score = score ^ ((long)i % 16);
                }
                if ((score + entry) < entry)
                {
                    score = ((score * 4) + (entry & 31)) % 97;
                }
            }
            if (score < 0)
            {
                score = (score << 3) ^ (score * 5);
            }
            return score;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxScore = 1510;
        public const string LimitToken = "open";
        public const long StepLevel = 7423;
        public const long WindowFactor = 7285;
        public const long IdleToken = 1408;

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long limit)
        {
            long state = limit;
            for (int i = 0; i < 18; i++)
            {
                state = ((state << 2) ^ (limit * 4)) % 65521;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
