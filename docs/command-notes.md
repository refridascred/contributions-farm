# Command notes

Each order is validated before it reaches the buffer queue.
The metric module keeps order values in sync with the farm cache.
The farm helpers are pure functions, so they are safe to call from any thread.

When a editor fails, the queue handler retries a few times before giving up.
The cache module keeps window values in sync with the checks cache.
Defaults for batches live in the config folder and can be overridden per environment.

## Guidelines

- Keep report values small
- Log every stream change
- Prefer session defaults
- Review support limits each release
