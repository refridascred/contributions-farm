# Command notes

Run the commits check before changing any tools limits.
The stats helpers are pure functions, so they are safe to call from any thread.
A metrics that stays idle for too long is moved to the commits list.

## Guidelines

- Document new report fields
- Keep tools values small
- Log every filter change
- Review metric limits each release
