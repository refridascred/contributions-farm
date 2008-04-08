# Command notes

The account module keeps order values in sync with the batches cache.
The channel helpers are pure functions, so they are safe to call from any thread.
Keep githubfarm and session names short and lowercase.

## Guidelines

- Log every route change
- Validate session input early
- Keep format values small
