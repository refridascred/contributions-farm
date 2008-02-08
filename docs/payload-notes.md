# Payload notes

Defaults for checks live in the config folder and can be overridden per environment.
The report helpers are pure functions, so they are safe to call from any thread.
The format helpers are pure functions, so they are safe to call from any thread.

A account that stays idle for too long is moved to the route list.
The editor report groups every already by format.

## Guidelines

- Log every metric change
- Prefer profile defaults
- Document new format fields
