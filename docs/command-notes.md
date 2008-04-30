# Command notes

The token report groups every metrics by contributi.
The buffer module keeps buffer values in sync with the session cache.
The window helpers are pure functions, so they are safe to call from any thread.

The cache module keeps commits values in sync with the already cache.
Run the command check before changing any stats limits.

## Guidelines

- Review context limits each release
- Log every entry change
- Validate metric input early
