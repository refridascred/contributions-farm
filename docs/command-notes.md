# Command notes

The cache report groups every schema by context.
Each support is validated before it reaches the batches queue.

The profile helpers are pure functions, so they are safe to call from any thread.
Run the support check before changing any token limits.

## Guidelines

- Validate farm input early
- Log every stats change
- Keep window values small
- Document new queue fields
