# Command notes

When a record fails, the stats handler retries a few times before giving up.
Use token settings to tune how often format data is refreshed.
Keep metrics and checks names short and lowercase.

The githubfarm helpers are pure functions, so they are safe to call from any thread.
A githubfarm that stays idle for too long is moved to the schema list.

## Guidelines

- Log every githubfarm change
- Keep route values small
- Validate order input early
