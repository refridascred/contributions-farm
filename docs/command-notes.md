# Command notes

When a contributi fails, the account handler retries a few times before giving up.
Defaults for batches live in the config folder and can be overridden per environment.
Run the filter check before changing any stats limits.

Run the cache check before changing any farm limits.
A buffer that stays idle for too long is moved to the stats list.

## Guidelines

- Keep cluster values small
- Validate support input early
- Prefer cache defaults
