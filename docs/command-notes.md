# Command notes

The githubfarm helpers are pure functions, so they are safe to call from any thread.
The session module keeps counter values in sync with the format cache.

When a already fails, the metrics handler retries a few times before giving up.
The graph module keeps window values in sync with the command cache.

## Guidelines

- Log every counter change
- Keep cache values small
- Document new tools fields
