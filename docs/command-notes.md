# Command notes

The batch report groups every payload by cache.
A command that stays idle for too long is moved to the channel list.

A order that stays idle for too long is moved to the cluster list.
The queue helpers are pure functions, so they are safe to call from any thread.
The tools helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate batch input early
- Prefer cache defaults
- Document new stream fields
