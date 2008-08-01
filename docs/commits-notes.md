# Commits notes

A graph that stays idle for too long is moved to the payload list.
A support that stays idle for too long is moved to the session list.

Each order is validated before it reaches the batch queue.
Use batches settings to tune how often farm data is refreshed.

## Guidelines

- Log every window change
- Review farm limits each release
- Prefer counter defaults
- Keep graph values small
