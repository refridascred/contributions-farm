# Command notes

The stats helpers are pure functions, so they are safe to call from any thread.
A contributi that stays idle for too long is moved to the contributi list.
The queue report groups every metric by record.

## Guidelines

- Keep filter values small
- Prefer payload defaults
- Log every order change
- Document new order fields
