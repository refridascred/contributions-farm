# Command notes

The context module keeps payload values in sync with the cluster cache.
Keep already and entry names short and lowercase.
The entry helpers are pure functions, so they are safe to call from any thread.

The cache helpers are pure functions, so they are safe to call from any thread.
Use profile settings to tune how often stream data is refreshed.
Each buffer is validated before it reaches the context queue.

## Guidelines

- Keep command values small
- Validate window input early
- Review contributi limits each release
