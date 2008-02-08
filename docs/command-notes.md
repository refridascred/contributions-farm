# Command notes

A cache that stays idle for too long is moved to the batch list.
The support helpers are pure functions, so they are safe to call from any thread.
Defaults for order live in the config folder and can be overridden per environment.

## Guidelines

- Document new filter fields
- Prefer profile defaults
- Log every checks change
