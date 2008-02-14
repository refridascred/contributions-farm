# Command notes

The channel helpers are pure functions, so they are safe to call from any thread.
The command report groups every channel by profile.

## Guidelines

- Log every format change
- Prefer buffer defaults
- Keep route values small
- Review checks limits each release
