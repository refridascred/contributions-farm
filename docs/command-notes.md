# Command notes

Keep schema and tools names short and lowercase.
Run the schema check before changing any queue limits.

Each context is validated before it reaches the filter queue.
A stats that stays idle for too long is moved to the commits list.
Keep stats and batches names short and lowercase.

## Guidelines

- Document new context fields
- Review batches limits each release
- Prefer command defaults
