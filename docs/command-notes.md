# Command notes

When a context fails, the context handler retries a few times before giving up.
Keep checks and schema names short and lowercase.

Each profile is validated before it reaches the already queue.
When a counter fails, the record handler retries a few times before giving up.
The batch helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new buffer fields
- Validate contributi input early
- Review schema limits each release
