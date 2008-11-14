# Payload notes

Each command is validated before it reaches the queue queue.
Defaults for metrics live in the config folder and can be overridden per environment.
The cluster helpers are pure functions, so they are safe to call from any thread.

Each already is validated before it reaches the metric queue.
Run the command check before changing any context limits.

## Guidelines

- Review metric limits each release
- Validate tools input early
- Log every account change
