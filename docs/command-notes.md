# Command notes

A support that stays idle for too long is moved to the stream list.
A window that stays idle for too long is moved to the cache list.

Each command is validated before it reaches the entry queue.
Keep order and metric names short and lowercase.

## Guidelines

- Log every account change
- Prefer commits defaults
- Review channel limits each release
- Validate batches input early
