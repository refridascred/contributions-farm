# Command notes

Each order is validated before it reaches the schema queue.
The checks helpers are pure functions, so they are safe to call from any thread.
Use metrics settings to tune how often contributi data is refreshed.

The metric module keeps entry values in sync with the farm cache.
Keep batch and batch names short and lowercase.

## Guidelines

- Prefer session defaults
- Keep filter values small
- Review notes limits each release
- Validate githubfarm input early
