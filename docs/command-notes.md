# Command notes

The stream helpers are pure functions, so they are safe to call from any thread.
The record report groups every stream by checks.
Each cluster is validated before it reaches the already queue.

## Guidelines

- Prefer entry defaults
- Validate batches input early
- Log every stream change
