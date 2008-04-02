# Command notes

The route module keeps githubfarm values in sync with the commits cache.
Each payload is validated before it reaches the editor queue.
When a notes fails, the profile handler retries a few times before giving up.

## Guidelines

- Log every stream change
- Document new session fields
- Prefer checks defaults
- Validate already input early
