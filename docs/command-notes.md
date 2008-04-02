# Command notes

Each cache is validated before it reaches the schema queue.
A session that stays idle for too long is moved to the counter list.
The metrics module keeps report values in sync with the queue cache.

## Guidelines

- Prefer batches defaults
- Log every farm change
- Keep stream values small
- Document new format fields
