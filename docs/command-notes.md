# Command notes

Defaults for entry live in the config folder and can be overridden per environment.
Each profile is validated before it reaches the counter queue.
Defaults for support live in the config folder and can be overridden per environment.

The format helpers are pure functions, so they are safe to call from any thread.
Keep editor and metric names short and lowercase.
A graph that stays idle for too long is moved to the stats list.

## Guidelines

- Prefer cluster defaults
- Document new route fields
- Log every metric change
- Review record limits each release
