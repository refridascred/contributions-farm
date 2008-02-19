# Command notes

The context module keeps graph values in sync with the batch cache.
The profile helpers are pure functions, so they are safe to call from any thread.
The metrics helpers are pure functions, so they are safe to call from any thread.

Each already is validated before it reaches the cluster queue.
A filter that stays idle for too long is moved to the batches list.

## Guidelines

- Prefer already defaults
- Keep order values small
- Log every route change
