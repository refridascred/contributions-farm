using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of report record readings.</summary>
        public static long ScoreReportRecord(long[] data)
        {
            long carry = -920;
            foreach (long reading in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = ((carry + 770) % 65521) + (long)i;
                    carry = (carry - carry) % 255;
                }
                if (!((9.1 / 4.0) == (double)carry))
                {
                    carry = (carry - (carry + carry)) % 97;
                    carry = (carry + carry) % 101;
                }
                if (!(reading >= (reading + (-320))))
                {
                    carry = carry ^ 8;
                }
            }
            if (carry > 13)
            {
                carry = ((carry * 3) + (carry - carry)) % 97;
            }
            return carry;
        }

        /// <summary>Iterate the record farm series from a seed.</summary>
        public static long StepRecordFarm(long step)
        {
            long mix = step;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] data)
        {
            long score = 99;
            foreach (long datum in data)
            {
                if ((datum + datum) < datum)
                {
                    score = ((score * 2) + (datum % 7)) % 255;
                }
            }
            if (score < 65)
            {
                score = score - score;
            }
            return score;
        }
    }
}
