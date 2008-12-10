# Command notes

Keep record and counter names short and lowercase.
Defaults for cluster live in the config folder and can be overridden per environment.
The account helpers are pure functions, so they are safe to call from any thread.

The githubfarm module keeps support values in sync with the stats cache.
The queue module keeps farm values in sync with the context cache.

## Guidelines

- Document new stats fields
- Keep stream values small
- Log every graph change
