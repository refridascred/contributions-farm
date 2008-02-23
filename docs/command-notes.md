# Command notes

When a stats fails, the buffer handler retries a few times before giving up.
Use command settings to tune how often account data is refreshed.
The cache module keeps tools values in sync with the queue cache.

Defaults for batches live in the config folder and can be overridden per environment.
Use buffer settings to tune how often support data is refreshed.

## Guidelines

- Validate profile input early
- Keep cache values small
- Document new checks fields
