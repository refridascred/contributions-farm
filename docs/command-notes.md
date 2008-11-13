# Command notes

The support helpers are pure functions, so they are safe to call from any thread.
A cluster that stays idle for too long is moved to the session list.
The cluster report groups every entry by support.

## Guidelines

- Keep window values small
- Log every metrics change
- Review support limits each release
