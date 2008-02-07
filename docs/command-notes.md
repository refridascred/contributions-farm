# Command notes

The schema report groups every editor by order.
Defaults for route live in the config folder and can be overridden per environment.
Each checks is validated before it reaches the route queue.

The queue helpers are pure functions, so they are safe to call from any thread.
Keep buffer and editor names short and lowercase.
When a layout fails, the record handler retries a few times before giving up.

## Guidelines

- Review graph limits each release
- Validate metric input early
- Prefer entry defaults
- Log every schema change
