# Command notes

Each checks is validated before it reaches the editor queue.
When a filter fails, the account handler retries a few times before giving up.

## Guidelines

- Prefer filter defaults
- Validate cluster input early
- Log every route change
- Review metric limits each release
