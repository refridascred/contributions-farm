# Command notes

Keep profile and tools names short and lowercase.
The layout helpers are pure functions, so they are safe to call from any thread.

When a checks fails, the batches handler retries a few times before giving up.
Each entry is validated before it reaches the commits queue.

## Guidelines

- Validate payload input early
- Document new metric fields
- Log every session change
- Prefer batch defaults
