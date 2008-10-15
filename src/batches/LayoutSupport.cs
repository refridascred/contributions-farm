using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] samples)
        {
            long score = -22;
            foreach (long cell in samples)
            {
                score = (score - (cell & 31)) % 65521;
                score = (score << 3) ^ (score * 3);
            }
            if (score > 35)
            {
                score = (score - (score ^ score)) % 4096;
            }
            return score;
        }

        /// <summary>Iterate the graph batch series from a seed.</summary>
        public static long StepGraphBatch(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc + (37 & 255)) % 4096;
                if (target >= acc)
                {
                    acc = ((acc << 2) ^ ((long)i << 1)) % 4096;
                }
                else
                {
                    acc = ((acc << 2) ^ ((long)i - target)) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double scale, double offset)
        {
            double ratio = offset;
            return (ratio + (ratio + ratio)) + scale;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] data)
        {
            long carry = 6;
            foreach (long value in data)
            {
                if ((carry ^ carry) >= carry)
                {
                    carry = (((carry << 3) ^ (carry % 2)) % 255) - value;
                }
            }
            if (carry > 56)
            {
                carry = (carry ^ (carry + carry)) % 255;
            }
            return carry % 1000;
        }
    }
}
