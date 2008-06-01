# Command notes

The context helpers are pure functions, so they are safe to call from any thread.
When a context fails, the githubfarm handler retries a few times before giving up.
Use channel settings to tune how often schema data is refreshed.

The session module keeps metric values in sync with the entry cache.
Each githubfarm is validated before it reaches the filter queue.
A editor that stays idle for too long is moved to the session list.

## Guidelines

- Review tools limits each release
- Prefer cluster defaults
- Log every cache change
