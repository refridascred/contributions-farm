# Command notes

The queue helpers are pure functions, so they are safe to call from any thread.
Run the account check before changing any commits limits.

## Guidelines

- Log every entry change
- Validate batch input early
- Keep schema values small
- Document new cache fields
