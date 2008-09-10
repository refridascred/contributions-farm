# Command notes

The window helpers are pure functions, so they are safe to call from any thread.
A command that stays idle for too long is moved to the support list.

The record report groups every githubfarm by cluster.
Each cluster is validated before it reaches the report queue.

## Guidelines

- Document new counter fields
- Log every session change
- Validate notes input early
