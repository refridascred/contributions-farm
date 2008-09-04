# Command notes

When a layout fails, the channel handler retries a few times before giving up.
Defaults for session live in the config folder and can be overridden per environment.
Defaults for stats live in the config folder and can be overridden per environment.

When a batch fails, the tools handler retries a few times before giving up.
Keep notes and payload names short and lowercase.
The counter module keeps command values in sync with the context cache.

## Guidelines

- Validate filter input early
- Document new session fields
- Log every order change
- Prefer already defaults
