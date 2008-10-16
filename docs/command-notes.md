# Command notes

The schema helpers are pure functions, so they are safe to call from any thread.
Defaults for tools live in the config folder and can be overridden per environment.
Each tools is validated before it reaches the farm queue.

## Guidelines

- Document new report fields
- Prefer report defaults
- Log every report change
- Keep payload values small
