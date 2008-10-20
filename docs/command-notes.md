# Command notes

Each commits is validated before it reaches the window queue.
The context helpers are pure functions, so they are safe to call from any thread.
Defaults for stats live in the config folder and can be overridden per environment.

## Guidelines

- Review batch limits each release
- Keep queue values small
- Document new profile fields
