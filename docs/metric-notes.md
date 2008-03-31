# Metric notes

Run the editor check before changing any record limits.
A token that stays idle for too long is moved to the tools list.

Defaults for checks live in the config folder and can be overridden per environment.
The order module keeps token values in sync with the context cache.
The route helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer buffer defaults
- Document new booking fields
- Validate support input early
