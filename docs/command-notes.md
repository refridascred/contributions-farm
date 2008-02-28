# Command notes

The farm report groups every context by report.
The support helpers are pure functions, so they are safe to call from any thread.
Each filter is validated before it reaches the schema queue.

A profile that stays idle for too long is moved to the token list.
The record report groups every order by queue.

## Guidelines

- Prefer commits defaults
- Log every record change
- Keep queue values small
- Review record limits each release
