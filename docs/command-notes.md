# Command notes

The notes module keeps report values in sync with the entry cache.
The queue helpers are pure functions, so they are safe to call from any thread.
Use filter settings to tune how often order data is refreshed.

Defaults for account live in the config folder and can be overridden per environment.
Run the channel check before changing any batch limits.
When a payload fails, the context handler retries a few times before giving up.

## Guidelines

- Log every account change
- Prefer schema defaults
- Review notes limits each release
