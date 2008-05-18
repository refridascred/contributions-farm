# Command notes

A report that stays idle for too long is moved to the session list.
The stats report groups every buffer by graph.

The command helpers are pure functions, so they are safe to call from any thread.
Run the farm check before changing any report limits.

## Guidelines

- Review graph limits each release
- Validate notes input early
- Keep profile values small
- Document new support fields
