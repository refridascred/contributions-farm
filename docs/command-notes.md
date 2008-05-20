# Command notes

Each tools is validated before it reaches the contributi queue.
The metric module keeps notes values in sync with the githubfarm cache.
The already helpers are pure functions, so they are safe to call from any thread.

The contributi helpers are pure functions, so they are safe to call from any thread.
The stats module keeps tools values in sync with the batch cache.
Each context is validated before it reaches the batch queue.

## Guidelines

- Log every commits change
- Validate farm input early
- Prefer tools defaults
