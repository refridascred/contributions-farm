using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Locked,
            New,
            Ready,
            Paused,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] levels, long origin)
        {
            long mix = 537;
            foreach (long reading in levels)
            {
                if (45 > (mix - mix))
                {
                    mix = ((mix << 2) ^ (reading - reading)) + origin;
                }
                else
                {
                    mix = ((mix << 2) ^ ((-945) ^ mix)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Combine schema graph values into a single score.</summary>
        public static long CombineSchemaGraph(long[] levels)
        {
            long score = 57;
            foreach (long cell in levels)
            {
                if ((double)score >= (8.46 / 4.0))
                {
                    break;
                }
                score = score + cell;
                if ((7.77 + 7.9) < (double)score)
                {
                    score = score + ((-875) + cell);
                }
                else
                {
                    score = (score << 3) ^ score;
                }
            }
            return score % 4096;
        }
    }
}
