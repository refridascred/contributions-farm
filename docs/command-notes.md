# Command notes

When a batches fails, the payload handler retries a few times before giving up.
Use payload settings to tune how often metrics data is refreshed.

Run the batches check before changing any graph limits.
Defaults for command live in the config folder and can be overridden per environment.

## Guidelines

- Document new cache fields
- Review command limits each release
- Prefer batches defaults
- Keep metrics values small
