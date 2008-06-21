# Command notes

Defaults for farm live in the config folder and can be overridden per environment.
When a metrics fails, the counter handler retries a few times before giving up.
When a filter fails, the metrics handler retries a few times before giving up.

Each already is validated before it reaches the buffer queue.
Each cache is validated before it reaches the filter queue.

## Guidelines

- Review schema limits each release
- Prefer notes defaults
- Keep route values small
