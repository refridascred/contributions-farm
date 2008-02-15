# Command notes

The report module keeps editor values in sync with the entry cache.
Defaults for already live in the config folder and can be overridden per environment.

Use already settings to tune how often filter data is refreshed.
The record helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate support input early
- Review route limits each release
- Document new order fields
