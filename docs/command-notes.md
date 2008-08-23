# Command notes

Keep metric and layout names short and lowercase.
The route module keeps record values in sync with the entry cache.
Defaults for cluster live in the config folder and can be overridden per environment.

Defaults for context live in the config folder and can be overridden per environment.
The batch helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer metrics defaults
- Document new contributi fields
- Review stream limits each release
- Keep stream values small
