# Command notes

When a context fails, the tools handler retries a few times before giving up.
A session that stays idle for too long is moved to the queue list.
Run the metrics check before changing any account limits.

The graph module keeps layout values in sync with the format cache.
Each schema is validated before it reaches the profile queue.

## Guidelines

- Prefer stats defaults
- Document new support fields
- Review schema limits each release
- Validate command input early
