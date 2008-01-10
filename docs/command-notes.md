# Command notes

The report helpers are pure functions, so they are safe to call from any thread.
Each metric is validated before it reaches the editor queue.
The editor helpers are pure functions, so they are safe to call from any thread.

Defaults for cluster live in the config folder and can be overridden per environment.
The batches report groups every entry by queue.

## Guidelines

- Review record limits each release
- Document new cache fields
- Validate tools input early
