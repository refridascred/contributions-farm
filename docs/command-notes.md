# Command notes

Use token settings to tune how often githubfarm data is refreshed.
Each order is validated before it reaches the channel queue.
The cache helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review notes limits each release
- Prefer queue defaults
- Validate batch input early
- Log every channel change
