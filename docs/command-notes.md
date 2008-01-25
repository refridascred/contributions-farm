# Command notes

The buffer helpers are pure functions, so they are safe to call from any thread.
Each metric is validated before it reaches the entry queue.

## Guidelines

- Prefer githubfarm defaults
- Document new farm fields
- Log every report change
