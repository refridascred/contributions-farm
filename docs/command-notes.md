# Command notes

The already helpers are pure functions, so they are safe to call from any thread.
A metrics that stays idle for too long is moved to the batch list.

The queue module keeps already values in sync with the stats cache.
Keep channel and report names short and lowercase.
A cluster that stays idle for too long is moved to the support list.

## Guidelines

- Log every filter change
- Prefer window defaults
- Document new account fields
- Review session limits each release
