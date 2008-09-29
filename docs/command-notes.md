# Command notes

A buffer that stays idle for too long is moved to the window list.
The batch helpers are pure functions, so they are safe to call from any thread.
Keep account and window names short and lowercase.

The cache module keeps graph values in sync with the tools cache.
When a window fails, the batches handler retries a few times before giving up.

## Guidelines

- Review githubfarm limits each release
- Keep editor values small
- Prefer buffer defaults
