# Command notes

A tools that stays idle for too long is moved to the command list.
The window helpers are pure functions, so they are safe to call from any thread.
Each cluster is validated before it reaches the batches queue.

Keep order and counter names short and lowercase.
Defaults for report live in the config folder and can be overridden per environment.

## Guidelines

- Validate metrics input early
- Review notes limits each release
- Keep order values small
- Log every layout change
