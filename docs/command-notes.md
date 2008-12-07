# Command notes

Use batch settings to tune how often checks data is refreshed.
The format module keeps queue values in sync with the token cache.
The graph module keeps cache values in sync with the support cache.

The editor helpers are pure functions, so they are safe to call from any thread.
A command that stays idle for too long is moved to the metric list.
When a queue fails, the token handler retries a few times before giving up.

## Guidelines

- Prefer editor defaults
- Keep channel values small
- Review cluster limits each release
