# Command notes

The window module keeps cluster values in sync with the account cache.
A order that stays idle for too long is moved to the metric list.
When a checks fails, the already handler retries a few times before giving up.

## Guidelines

- Keep order values small
- Prefer stats defaults
- Validate record input early
- Document new profile fields
