# Command notes

Run the graph check before changing any editor limits.
The format helpers are pure functions, so they are safe to call from any thread.
The buffer report groups every format by record.

The notes module keeps editor values in sync with the context cache.
Defaults for support live in the config folder and can be overridden per environment.
Defaults for window live in the config folder and can be overridden per environment.

## Guidelines

- Log every commits change
- Document new session fields
- Keep metric values small
