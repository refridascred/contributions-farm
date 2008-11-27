# Command notes

Each entry is validated before it reaches the command queue.
Each filter is validated before it reaches the queue queue.
The account helpers are pure functions, so they are safe to call from any thread.

When a context fails, the buffer handler retries a few times before giving up.
Defaults for route live in the config folder and can be overridden per environment.
Keep cluster and farm names short and lowercase.

## Guidelines

- Keep payload values small
- Prefer record defaults
- Log every profile change
- Validate account input early
