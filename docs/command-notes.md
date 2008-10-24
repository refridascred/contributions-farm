# Command notes

The stream helpers are pure functions, so they are safe to call from any thread.
The batches module keeps command values in sync with the order cache.
Use contributi settings to tune how often session data is refreshed.

## Guidelines

- Log every filter change
- Keep support values small
- Validate metrics input early
