# Command notes

The route helpers are pure functions, so they are safe to call from any thread.
When a filter fails, the stats handler retries a few times before giving up.

## Guidelines

- Log every buffer change
- Validate notes input early
- Prefer githubfarm defaults
