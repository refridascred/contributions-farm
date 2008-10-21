# Command notes

The graph helpers are pure functions, so they are safe to call from any thread.
Use graph settings to tune how often batch data is refreshed.
A farm that stays idle for too long is moved to the window list.

Defaults for route live in the config folder and can be overridden per environment.
When a batches fails, the order handler retries a few times before giving up.
Run the batches check before changing any checks limits.

## Guidelines

- Keep checks values small
- Log every layout change
- Validate account input early
