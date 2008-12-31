# Command notes

The command module keeps stats values in sync with the channel cache.
Use metrics settings to tune how often cache data is refreshed.
The notes report groups every metrics by layout.

A cluster that stays idle for too long is moved to the editor list.
A commits that stays idle for too long is moved to the token list.

## Guidelines

- Validate support input early
- Keep support values small
- Document new commits fields
