# Command notes

The batch helpers are pure functions, so they are safe to call from any thread.
The context module keeps commits values in sync with the queue cache.
A buffer that stays idle for too long is moved to the editor list.

## Guidelines

- Review format limits each release
- Document new editor fields
- Keep stream values small
- Log every cache change
