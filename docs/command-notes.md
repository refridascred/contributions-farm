# Command notes

Run the support check before changing any command limits.
The filter module keeps graph values in sync with the format cache.
A notes that stays idle for too long is moved to the batch list.

Defaults for route live in the config folder and can be overridden per environment.
The command helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every farm change
- Review report limits each release
- Validate checks input early
