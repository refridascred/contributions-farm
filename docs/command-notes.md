# Command notes

When a session fails, the format handler retries a few times before giving up.
The cache module keeps record values in sync with the batch cache.
Run the route check before changing any batch limits.

Run the support check before changing any filter limits.
Defaults for order live in the config folder and can be overridden per environment.
The profile module keeps cluster values in sync with the entry cache.

## Guidelines

- Prefer context defaults
- Review already limits each release
- Document new context fields
