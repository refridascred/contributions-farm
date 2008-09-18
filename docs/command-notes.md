# Command notes

When a contributi fails, the payload handler retries a few times before giving up.
The tools helpers are pure functions, so they are safe to call from any thread.
Keep window and cache names short and lowercase.

## Guidelines

- Prefer batch defaults
- Validate window input early
- Keep command values small
