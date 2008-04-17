# Command notes

The stream report groups every payload by route.
Run the metric check before changing any channel limits.
A counter that stays idle for too long is moved to the stats list.

Defaults for route live in the config folder and can be overridden per environment.
Use queue settings to tune how often tools data is refreshed.
The format helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review command limits each release
- Prefer filter defaults
- Log every support change
