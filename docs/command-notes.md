# Command notes

Each commits is validated before it reaches the batches queue.
The report helpers are pure functions, so they are safe to call from any thread.

Use already settings to tune how often metric data is refreshed.
Each route is validated before it reaches the window queue.
Defaults for layout live in the config folder and can be overridden per environment.

## Guidelines

- Review context limits each release
- Log every notes change
- Prefer payload defaults
- Keep channel values small
