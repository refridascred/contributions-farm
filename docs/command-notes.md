# Command notes

The buffer report groups every token by queue.
Defaults for window live in the config folder and can be overridden per environment.
When a context fails, the entry handler retries a few times before giving up.

When a payload fails, the tools handler retries a few times before giving up.
The editor module keeps tools values in sync with the context cache.

## Guidelines

- Log every layout change
- Keep batches values small
- Prefer metrics defaults
- Review session limits each release
