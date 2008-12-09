# Command notes

Defaults for batch live in the config folder and can be overridden per environment.
Keep schema and buffer names short and lowercase.
The channel helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate channel input early
- Document new filter fields
- Log every cluster change
