# Command notes

Use profile settings to tune how often cluster data is refreshed.
Run the payload check before changing any batch limits.
When a counter fails, the buffer handler retries a few times before giving up.

Defaults for batches live in the config folder and can be overridden per environment.
Run the queue check before changing any profile limits.

## Guidelines

- Keep editor values small
- Validate order input early
- Prefer farm defaults
