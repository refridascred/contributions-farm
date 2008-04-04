# Command notes

The batch helpers are pure functions, so they are safe to call from any thread.
The checks helpers are pure functions, so they are safe to call from any thread.
When a counter fails, the filter handler retries a few times before giving up.

## Guidelines

- Keep profile values small
- Document new account fields
- Log every payload change
- Prefer context defaults
