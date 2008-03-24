# Command notes

The cluster report groups every window by tools.
The graph module keeps buffer values in sync with the notes cache.

Defaults for metrics live in the config folder and can be overridden per environment.
Each layout is validated before it reaches the report queue.
When a metric fails, the context handler retries a few times before giving up.

## Guidelines

- Keep report values small
- Prefer commits defaults
- Log every metrics change
