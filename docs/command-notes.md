# Command notes

The graph module keeps contributi values in sync with the schema cache.
Each tools is validated before it reaches the githubfarm queue.

Defaults for profile live in the config folder and can be overridden per environment.
The report helpers are pure functions, so they are safe to call from any thread.
The already helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep checks values small
- Log every report change
- Validate token input early
- Document new queue fields
