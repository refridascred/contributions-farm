# Command notes

The profile helpers are pure functions, so they are safe to call from any thread.
The channel report groups every context by report.
When a metric fails, the layout handler retries a few times before giving up.

Each counter is validated before it reaches the farm queue.
The filter report groups every commits by already.
When a commits fails, the schema handler retries a few times before giving up.

## Guidelines

- Review batch limits each release
- Validate stream input early
- Prefer report defaults
