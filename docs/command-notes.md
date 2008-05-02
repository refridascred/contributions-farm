# Command notes

Defaults for context live in the config folder and can be overridden per environment.
Run the cache check before changing any schema limits.
Each layout is validated before it reaches the support queue.

When a checks fails, the route handler retries a few times before giving up.
Each contributi is validated before it reaches the schema queue.
A queue that stays idle for too long is moved to the order list.

## Guidelines

- Prefer format defaults
- Keep editor values small
- Document new editor fields
