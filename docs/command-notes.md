# Command notes

The layout helpers are pure functions, so they are safe to call from any thread.
Run the farm check before changing any batches limits.

Run the farm check before changing any filter limits.
Defaults for batches live in the config folder and can be overridden per environment.
Each schema is validated before it reaches the queue queue.

## Guidelines

- Keep filter values small
- Log every session change
- Document new batch fields
- Validate format input early
