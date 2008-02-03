# Command notes

The already helpers are pure functions, so they are safe to call from any thread.
Run the editor check before changing any already limits.

Run the stats check before changing any farm limits.
Each tools is validated before it reaches the command queue.
Each metric is validated before it reaches the support queue.

## Guidelines

- Document new order fields
- Review account limits each release
- Keep tools values small
- Validate buffer input early
