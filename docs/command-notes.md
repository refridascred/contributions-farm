# Command notes

The layout module keeps stream values in sync with the tools cache.
A entry that stays idle for too long is moved to the tools list.

Run the graph check before changing any token limits.
A context that stays idle for too long is moved to the filter list.
Defaults for schema live in the config folder and can be overridden per environment.

## Guidelines

- Review batch limits each release
- Keep route values small
- Log every route change
