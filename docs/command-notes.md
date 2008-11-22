# Command notes

Run the graph check before changing any stream limits.
Run the editor check before changing any editor limits.
A batch that stays idle for too long is moved to the payload list.

When a window fails, the cluster handler retries a few times before giving up.
The cluster module keeps stream values in sync with the stats cache.
The tools helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review githubfarm limits each release
- Keep entry values small
- Log every tools change
- Validate payload input early
