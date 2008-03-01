# Command notes

Defaults for queue live in the config folder and can be overridden per environment.
Each contributi is validated before it reaches the counter queue.
The support module keeps window values in sync with the report cache.

Each layout is validated before it reaches the filter queue.
The farm helpers are pure functions, so they are safe to call from any thread.
When a order fails, the context handler retries a few times before giving up.

## Guidelines

- Validate metrics input early
- Prefer counter defaults
- Log every entry change
- Document new context fields
