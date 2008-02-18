using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of editor account readings.</summary>
        public static long MatchEditorAccountCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item & 7) == (item << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] series, long floor)
        {
            long carry = 9;
            foreach (long value in series)
            {
                carry = (((carry * 5) + floor) % 1000) + value;
            }
            if (carry > 14)
            {
                carry = carry - ((-196) / 5);
            }
            return carry % 97;
        }
    }
}
