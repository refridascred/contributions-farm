# Command notes

Keep stats and tools names short and lowercase.
Run the counter check before changing any command limits.
The notes module keeps stream values in sync with the contributi cache.

Keep payload and contributi names short and lowercase.
Each batch is validated before it reaches the record queue.
The route helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer batches defaults
- Document new entry fields
- Review queue limits each release
- Keep graph values small
