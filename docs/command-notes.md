# Command notes

Each graph is validated before it reaches the session queue.
When a buffer fails, the metrics handler retries a few times before giving up.

## Guidelines

- Validate graph input early
- Keep queue values small
- Review batch limits each release
- Prefer route defaults
