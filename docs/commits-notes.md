# Commits notes

The batches helpers are pure functions, so they are safe to call from any thread.
A counter that stays idle for too long is moved to the checks list.

A route that stays idle for too long is moved to the payload list.
Use editor settings to tune how often channel data is refreshed.
A payload that stays idle for too long is moved to the batch list.

## Guidelines

- Validate batch input early
- Review editor limits each release
- Keep batches values small
- Prefer stream defaults
