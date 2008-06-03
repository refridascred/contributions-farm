# Command notes

Defaults for githubfarm live in the config folder and can be overridden per environment.
The channel module keeps stats values in sync with the schema cache.
Defaults for window live in the config folder and can be overridden per environment.

A cluster that stays idle for too long is moved to the notes list.
A notes that stays idle for too long is moved to the farm list.

## Guidelines

- Review batches limits each release
- Keep batches values small
- Log every command change
