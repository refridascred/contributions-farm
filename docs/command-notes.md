# Command notes

A cache that stays idle for too long is moved to the cache list.
Run the command check before changing any githubfarm limits.
A buffer that stays idle for too long is moved to the filter list.

The order module keeps command values in sync with the checks cache.
The stream module keeps session values in sync with the layout cache.
Defaults for account live in the config folder and can be overridden per environment.

## Guidelines

- Keep buffer values small
- Log every session change
- Document new metrics fields
- Validate metrics input early
