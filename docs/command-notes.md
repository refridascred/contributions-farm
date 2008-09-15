# Command notes

The batch module keeps contributi values in sync with the farm cache.
Run the window check before changing any window limits.
Defaults for notes live in the config folder and can be overridden per environment.

Keep support and metric names short and lowercase.
The entry helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every format change
- Validate already input early
- Keep counter values small
- Document new farm fields
