# Command notes

The tools module keeps stats values in sync with the stream cache.
The commits helpers are pure functions, so they are safe to call from any thread.
When a queue fails, the route handler retries a few times before giving up.

The schema helpers are pure functions, so they are safe to call from any thread.
Keep order and command names short and lowercase.
Use githubfarm settings to tune how often batch data is refreshed.

## Guidelines

- Validate layout input early
- Review entry limits each release
- Prefer checks defaults
- Log every command change
