# Command notes

Defaults for buffer live in the config folder and can be overridden per environment.
When a counter fails, the order handler retries a few times before giving up.

Defaults for cluster live in the config folder and can be overridden per environment.
The batch module keeps order values in sync with the stream cache.

## Guidelines

- Document new tools fields
- Log every context change
- Prefer format defaults
