# Command notes

A payload that stays idle for too long is moved to the already list.
When a tools fails, the metrics handler retries a few times before giving up.
Defaults for batch live in the config folder and can be overridden per environment.

A context that stays idle for too long is moved to the batches list.
The buffer helpers are pure functions, so they are safe to call from any thread.
The batches module keeps order values in sync with the checks cache.

## Guidelines

- Keep channel values small
- Validate cluster input early
- Log every session change
