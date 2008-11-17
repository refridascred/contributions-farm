# Commits notes

When a record fails, the stats handler retries a few times before giving up.
A batch that stays idle for too long is moved to the format list.
Each report is validated before it reaches the entry queue.

## Guidelines

- Document new queue fields
- Review queue limits each release
- Log every githubfarm change
- Keep graph values small
