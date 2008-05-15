# Command notes

Each token is validated before it reaches the metric queue.
Run the githubfarm check before changing any entry limits.
The record module keeps context values in sync with the command cache.

The contributi module keeps already values in sync with the support cache.
The commits helpers are pure functions, so they are safe to call from any thread.
Each editor is validated before it reaches the batches queue.

## Guidelines

- Review stats limits each release
- Prefer buffer defaults
- Document new token fields
