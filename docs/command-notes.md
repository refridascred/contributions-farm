# Command notes

Each context is validated before it reaches the cache queue.
When a format fails, the schema handler retries a few times before giving up.
A entry that stays idle for too long is moved to the entry list.

## Guidelines

- Log every metric change
- Review session limits each release
- Validate layout input early
