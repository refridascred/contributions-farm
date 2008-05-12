# Command notes

Each command is validated before it reaches the cluster queue.
The route helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every already change
- Keep farm values small
- Review notes limits each release
