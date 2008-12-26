# Command notes

The support module keeps support values in sync with the queue cache.
Run the queue check before changing any record limits.
A order that stays idle for too long is moved to the channel list.

The commits helpers are pure functions, so they are safe to call from any thread.
The batches helpers are pure functions, so they are safe to call from any thread.
The layout module keeps metric values in sync with the session cache.

## Guidelines

- Keep commits values small
- Prefer graph defaults
- Document new format fields
