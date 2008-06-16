# Command notes

A cache that stays idle for too long is moved to the cluster list.
When a graph fails, the queue handler retries a few times before giving up.
A metric that stays idle for too long is moved to the entry list.

## Guidelines

- Prefer support defaults
- Log every token change
- Validate checks input early
