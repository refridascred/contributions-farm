# Command notes

Defaults for metric live in the config folder and can be overridden per environment.
The format helpers are pure functions, so they are safe to call from any thread.
The cluster report groups every format by stats.

## Guidelines

- Log every report change
- Document new batches fields
- Review metrics limits each release
- Keep command values small
