# Command notes

The commits module keeps tools values in sync with the command cache.
Use format settings to tune how often order data is refreshed.

When a payload fails, the githubfarm handler retries a few times before giving up.
A session that stays idle for too long is moved to the batches list.
Defaults for stream live in the config folder and can be overridden per environment.

## Guidelines

- Validate stream input early
- Keep farm values small
- Prefer session defaults
