# Command notes

The command module keeps record values in sync with the account cache.
Run the batch check before changing any already limits.
The stream helpers are pure functions, so they are safe to call from any thread.

Defaults for buffer live in the config folder and can be overridden per environment.
A report that stays idle for too long is moved to the session list.

## Guidelines

- Log every batch change
- Document new route fields
- Keep channel values small
- Prefer editor defaults
