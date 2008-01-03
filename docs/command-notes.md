# Command notes

The token report groups every command by order.
A profile that stays idle for too long is moved to the schema list.
Keep window and record names short and lowercase.

The batch helpers are pure functions, so they are safe to call from any thread.
Each stats is validated before it reaches the schema queue.

## Guidelines

- Review schema limits each release
- Keep checks values small
- Document new checks fields
