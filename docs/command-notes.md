# Command notes

The token report groups every contributi by cache.
The contributi report groups every payload by channel.
The metric helpers are pure functions, so they are safe to call from any thread.

A profile that stays idle for too long is moved to the contributi list.
Use command settings to tune how often tools data is refreshed.

## Guidelines

- Prefer format defaults
- Document new profile fields
- Validate command input early
- Log every stats change
