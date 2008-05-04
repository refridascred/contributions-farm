# Command notes

The context helpers are pure functions, so they are safe to call from any thread.
Each schema is validated before it reaches the tools queue.

The notes report groups every session by metric.
Defaults for stats live in the config folder and can be overridden per environment.

## Guidelines

- Log every filter change
- Document new checks fields
- Keep buffer values small
- Review format limits each release
