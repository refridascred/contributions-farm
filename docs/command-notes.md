# Command notes

The order module keeps stats values in sync with the payload cache.
A route that stays idle for too long is moved to the layout list.
Run the profile check before changing any window limits.

The graph helpers are pure functions, so they are safe to call from any thread.
Keep editor and format names short and lowercase.
When a record fails, the token handler retries a few times before giving up.

## Guidelines

- Review route limits each release
- Prefer account defaults
- Keep editor values small
