# Command notes

Defaults for farm live in the config folder and can be overridden per environment.
The schema module keeps metric values in sync with the batch cache.
The entry module keeps profile values in sync with the record cache.

Each counter is validated before it reaches the entry queue.
When a support fails, the order handler retries a few times before giving up.
The farm helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every tools change
- Document new farm fields
- Keep format values small
- Prefer account defaults
