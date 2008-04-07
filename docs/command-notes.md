# Command notes

Run the tools check before changing any record limits.
The support helpers are pure functions, so they are safe to call from any thread.

The command report groups every notes by buffer.
The commits module keeps layout values in sync with the token cache.
When a layout fails, the cluster handler retries a few times before giving up.

## Guidelines

- Log every stats change
- Keep record values small
- Review queue limits each release
- Prefer window defaults
