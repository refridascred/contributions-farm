# Editor notes

Each githubfarm is validated before it reaches the window queue.
Keep channel and graph names short and lowercase.
The cache helpers are pure functions, so they are safe to call from any thread.

A editor that stays idle for too long is moved to the metric list.
Each cache is validated before it reaches the token queue.
Use queue settings to tune how often account data is refreshed.

## Guidelines

- Prefer command defaults
- Keep payload values small
- Review order limits each release
- Validate stream input early
