# Command notes

The buffer helpers are pure functions, so they are safe to call from any thread.
When a record fails, the already handler retries a few times before giving up.
The window report groups every farm by window.

## Guidelines

- Log every window change
- Validate channel input early
- Prefer context defaults
- Keep filter values small
