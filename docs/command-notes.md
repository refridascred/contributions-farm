# Command notes

Each githubfarm is validated before it reaches the route queue.
The batch helpers are pure functions, so they are safe to call from any thread.
A order that stays idle for too long is moved to the commits list.

Run the channel check before changing any notes limits.
Each stream is validated before it reaches the checks queue.
The account helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every context change
- Keep commits values small
- Review tools limits each release
