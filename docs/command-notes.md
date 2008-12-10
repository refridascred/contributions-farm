# Command notes

Each batches is validated before it reaches the record queue.
A filter that stays idle for too long is moved to the session list.
Keep farm and batch names short and lowercase.

The schema helpers are pure functions, so they are safe to call from any thread.
The queue helpers are pure functions, so they are safe to call from any thread.
Use route settings to tune how often githubfarm data is refreshed.

## Guidelines

- Log every layout change
- Prefer farm defaults
- Review metric limits each release
- Keep notes values small
