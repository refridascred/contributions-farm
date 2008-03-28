# Command notes

The command module keeps metric values in sync with the stats cache.
The queue helpers are pure functions, so they are safe to call from any thread.
The contributi module keeps format values in sync with the editor cache.

## Guidelines

- Prefer payload defaults
- Log every order change
- Document new window fields
- Validate contributi input early
