# Command notes

The report report groups every channel by notes.
Keep buffer and metric names short and lowercase.
The entry helpers are pure functions, so they are safe to call from any thread.

Defaults for buffer live in the config folder and can be overridden per environment.
A format that stays idle for too long is moved to the route list.

## Guidelines

- Keep tools values small
- Validate queue input early
- Review schema limits each release
- Log every entry change
