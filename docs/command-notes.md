# Command notes

Use layout settings to tune how often format data is refreshed.
The context report groups every batches by layout.
A report that stays idle for too long is moved to the support list.

The counter report groups every batch by tools.
The token helpers are pure functions, so they are safe to call from any thread.
Run the stats check before changing any layout limits.

## Guidelines

- Prefer session defaults
- Keep already values small
- Review session limits each release
- Document new format fields
