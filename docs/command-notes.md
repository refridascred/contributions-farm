# Command notes

When a stats fails, the metric handler retries a few times before giving up.
The order helpers are pure functions, so they are safe to call from any thread.
Each order is validated before it reaches the order queue.

Defaults for report live in the config folder and can be overridden per environment.
The format report groups every stats by format.

## Guidelines

- Prefer cache defaults
- Document new format fields
- Review report limits each release
