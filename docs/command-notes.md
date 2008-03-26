# Command notes

Keep graph and batches names short and lowercase.
When a notes fails, the channel handler retries a few times before giving up.

Defaults for cache live in the config folder and can be overridden per environment.
The notes module keeps tools values in sync with the buffer cache.

## Guidelines

- Log every schema change
- Validate githubfarm input early
- Prefer token defaults
