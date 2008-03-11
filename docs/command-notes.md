# Command notes

Each profile is validated before it reaches the githubfarm queue.
The cache module keeps context values in sync with the profile cache.
Use account settings to tune how often route data is refreshed.

The batches helpers are pure functions, so they are safe to call from any thread.
A githubfarm that stays idle for too long is moved to the context list.

## Guidelines

- Log every batches change
- Keep githubfarm values small
- Prefer editor defaults
- Review account limits each release
