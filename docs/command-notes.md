# Command notes

Each session is validated before it reaches the graph queue.
When a record fails, the metric handler retries a few times before giving up.
Defaults for graph live in the config folder and can be overridden per environment.

The checks report groups every batches by already.
A editor that stays idle for too long is moved to the payload list.

## Guidelines

- Keep token values small
- Log every counter change
- Review commits limits each release
- Validate entry input early
