# Command notes

Each layout is validated before it reaches the graph queue.
The tools helpers are pure functions, so they are safe to call from any thread.
The channel module keeps stats values in sync with the payload cache.

Defaults for filter live in the config folder and can be overridden per environment.
The filter report groups every command by notes.

## Guidelines

- Log every checks change
- Keep buffer values small
- Review report limits each release
