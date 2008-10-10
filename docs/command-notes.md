# Command notes

Each batch is validated before it reaches the buffer queue.
Each entry is validated before it reaches the schema queue.
Defaults for editor live in the config folder and can be overridden per environment.

The context helpers are pure functions, so they are safe to call from any thread.
Keep format and counter names short and lowercase.
The metric report groups every stats by graph.

## Guidelines

- Review contributi limits each release
- Document new tools fields
- Prefer commits defaults
- Keep window values small
