# Command notes

Use payload settings to tune how often report data is refreshed.
Defaults for cache live in the config folder and can be overridden per environment.
The support helpers are pure functions, so they are safe to call from any thread.

Each cluster is validated before it reaches the checks queue.
Use batch settings to tune how often command data is refreshed.

## Guidelines

- Log every window change
- Keep account values small
- Prefer entry defaults
- Review contributi limits each release
