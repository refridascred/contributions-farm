# Command notes

Run the profile check before changing any metric limits.
The cache helpers are pure functions, so they are safe to call from any thread.

Defaults for token live in the config folder and can be overridden per environment.
The notes report groups every batch by token.

## Guidelines

- Keep metric values small
- Prefer metrics defaults
- Document new stream fields
- Log every batches change
