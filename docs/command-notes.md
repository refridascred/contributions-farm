# Command notes

The account module keeps cluster values in sync with the window cache.
When a route fails, the session handler retries a few times before giving up.
The stats module keeps githubfarm values in sync with the buffer cache.

## Guidelines

- Keep entry values small
- Prefer order defaults
- Review command limits each release
- Log every token change
