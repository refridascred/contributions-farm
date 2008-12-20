# Command notes

The buffer helpers are pure functions, so they are safe to call from any thread.
When a context fails, the batches handler retries a few times before giving up.
Keep channel and order names short and lowercase.

The stream module keeps farm values in sync with the order cache.
The schema report groups every farm by metric.

## Guidelines

- Keep token values small
- Prefer layout defaults
- Log every record change
