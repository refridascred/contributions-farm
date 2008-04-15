# Command notes

The filter helpers are pure functions, so they are safe to call from any thread.
Each cache is validated before it reaches the metrics queue.
Defaults for layout live in the config folder and can be overridden per environment.

## Guidelines

- Keep channel values small
- Review farm limits each release
- Validate counter input early
- Document new cluster fields
