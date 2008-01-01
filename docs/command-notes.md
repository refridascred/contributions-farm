# Command notes

Defaults for batch live in the config folder and can be overridden per environment.
A filter that stays idle for too long is moved to the entry list.
A order that stays idle for too long is moved to the channel list.

The metric module keeps entry values in sync with the context cache.
The batch report groups every format by tools.
Each context is validated before it reaches the profile queue.

## Guidelines

- Log every batch change
- Document new context fields
- Review graph limits each release
