# Command notes

The metric module keeps token values in sync with the farm cache.
A record that stays idle for too long is moved to the stats list.
The stream helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate batches input early
- Keep contributi values small
- Log every githubfarm change
