# Command notes

Use editor settings to tune how often channel data is refreshed.
The commits module keeps buffer values in sync with the contributi cache.
Use tools settings to tune how often counter data is refreshed.

The notes module keeps graph values in sync with the record cache.
Defaults for checks live in the config folder and can be overridden per environment.
A contributi that stays idle for too long is moved to the batches list.

## Guidelines

- Log every notes change
- Review route limits each release
- Document new already fields
- Keep metric values small
