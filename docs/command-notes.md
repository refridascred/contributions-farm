# Command notes

The graph module keeps buffer values in sync with the entry cache.
Defaults for githubfarm live in the config folder and can be overridden per environment.
A githubfarm that stays idle for too long is moved to the commits list.

## Guidelines

- Document new command fields
- Log every filter change
- Validate entry input early
