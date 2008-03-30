# Metric notes

Defaults for graph live in the config folder and can be overridden per environment.
The report helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate context input early
- Keep channel values small
- Prefer metric defaults
- Log every report change
