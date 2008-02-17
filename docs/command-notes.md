# Command notes

The route report groups every schema by metric.
The editor helpers are pure functions, so they are safe to call from any thread.
Each payload is validated before it reaches the already queue.

Each profile is validated before it reaches the metric queue.
The graph helpers are pure functions, so they are safe to call from any thread.
Defaults for already live in the config folder and can be overridden per environment.

## Guidelines

- Document new support fields
- Validate context input early
- Log every commits change
