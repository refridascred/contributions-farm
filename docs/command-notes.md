# Command notes

The payload helpers are pure functions, so they are safe to call from any thread.
The stats module keeps batches values in sync with the checks cache.
Run the batch check before changing any account limits.

Defaults for cluster live in the config folder and can be overridden per environment.
Each queue is validated before it reaches the batch queue.

## Guidelines

- Validate buffer input early
- Keep report values small
- Log every record change
- Prefer order defaults
