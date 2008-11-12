# Command notes

Each stream is validated before it reaches the channel queue.
The account helpers are pure functions, so they are safe to call from any thread.
The entry report groups every contributi by farm.

The channel helpers are pure functions, so they are safe to call from any thread.
Use editor settings to tune how often format data is refreshed.

## Guidelines

- Prefer metric defaults
- Keep githubfarm values small
- Log every payload change
