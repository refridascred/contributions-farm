# Command notes

Each metric is validated before it reaches the format queue.
Run the report check before changing any batches limits.
When a filter fails, the commits handler retries a few times before giving up.

A stream that stays idle for too long is moved to the githubfarm list.
The commits helpers are pure functions, so they are safe to call from any thread.
Keep command and farm names short and lowercase.

## Guidelines

- Review entry limits each release
- Prefer profile defaults
- Validate editor input early
