# Command notes

Each cache is validated before it reaches the channel queue.
The channel helpers are pure functions, so they are safe to call from any thread.
The buffer helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate order input early
- Review layout limits each release
- Keep token values small
- Log every stats change
