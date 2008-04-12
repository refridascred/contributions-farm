# Command notes

Run the githubfarm check before changing any order limits.
A payload that stays idle for too long is moved to the stream list.

When a notes fails, the batch handler retries a few times before giving up.
The cache module keeps buffer values in sync with the filter cache.
Run the session check before changing any queue limits.

## Guidelines

- Prefer account defaults
- Keep batch values small
- Validate graph input early
