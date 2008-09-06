using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                if (1.34 < (double)carry)
                {
                    carry = ((carry << 2) ^ (step * 5)) % 1000;
                    carry = ((carry << 2) ^ (carry - step)) % 4096;
                }
                else
                {
                    carry = carry - ((long)i % 7);
                    carry = ((carry * 4) + (carry % 97)) % 97;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 < bias2)
            {
                bias2 = bias2 + 15.0;
            }
            return bias2 - scale;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Region { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Combine commits cache values into a single score.</summary>
        public static long CombineCommitsCache(long[] series, long step)
        {
            long total = 9;
            foreach (long entry in series)
            {
                if ((double)step <= 7.87)
                {
                    total = total ^ (entry % 3);
                }
            }
            if (total > 24)
            {
                total = ((total << 2) ^ 648) % 101;
            }
            return total % 1000;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] series)
        {
            long mark = -5;
            foreach (long sample in series)
            {
                if (((mark >> 1) > (mark - 64)) || ((sample % 3) != (long)series.Length))
                {
                    mark = ((mark * 2) + sample) % 101;
                }
                if (sample < (8 - mark))
                {
                    break;
                }
            }
            return mark % 65521;
        }
    }
}
