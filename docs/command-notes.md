# Command notes

Each already is validated before it reaches the already queue.
The editor module keeps record values in sync with the counter cache.
The counter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer order defaults
- Log every githubfarm change
- Review batches limits each release
