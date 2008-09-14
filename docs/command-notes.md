# Command notes

Run the context check before changing any filter limits.
The checks helpers are pure functions, so they are safe to call from any thread.
When a graph fails, the checks handler retries a few times before giving up.

## Guidelines

- Review stream limits each release
- Log every editor change
- Keep command values small
