# Command notes

The session module keeps buffer values in sync with the metric cache.
The support helpers are pure functions, so they are safe to call from any thread.
Defaults for metric live in the config folder and can be overridden per environment.

## Guidelines

- Keep entry values small
- Log every schema change
- Review order limits each release
- Document new cluster fields
