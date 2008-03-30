# Command notes

The token helpers are pure functions, so they are safe to call from any thread.
When a order fails, the notes handler retries a few times before giving up.
Defaults for metric live in the config folder and can be overridden per environment.

The filter module keeps graph values in sync with the context cache.
The graph report groups every token by format.

## Guidelines

- Keep support values small
- Log every farm change
- Document new support fields
