# Command notes

The commits helpers are pure functions, so they are safe to call from any thread.
Use editor settings to tune how often report data is refreshed.

Each githubfarm is validated before it reaches the metrics queue.
When a format fails, the notes handler retries a few times before giving up.
Each format is validated before it reaches the window queue.

## Guidelines

- Review graph limits each release
- Log every graph change
- Prefer profile defaults
