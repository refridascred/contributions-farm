# Command notes

The githubfarm module keeps profile values in sync with the context cache.
When a notes fails, the githubfarm handler retries a few times before giving up.

## Guidelines

- Document new support fields
- Keep batches values small
- Validate command input early
- Prefer metric defaults
