# Command notes

Each route is validated before it reaches the layout queue.
A contributi that stays idle for too long is moved to the route list.
Run the session check before changing any profile limits.

Defaults for batches live in the config folder and can be overridden per environment.
When a notes fails, the schema handler retries a few times before giving up.

## Guidelines

- Validate metrics input early
- Prefer window defaults
- Review schema limits each release
- Document new batch fields
