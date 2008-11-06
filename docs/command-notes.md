# Command notes

Keep stats and context names short and lowercase.
A checks that stays idle for too long is moved to the command list.

Use editor settings to tune how often stats data is refreshed.
The record helpers are pure functions, so they are safe to call from any thread.
The metrics report groups every buffer by buffer.

## Guidelines

- Prefer cache defaults
- Log every account change
- Keep session values small
- Review queue limits each release
