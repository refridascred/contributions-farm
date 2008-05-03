# Command notes

Run the stats check before changing any schema limits.
A profile that stays idle for too long is moved to the format list.
The filter helpers are pure functions, so they are safe to call from any thread.

Each layout is validated before it reaches the metric queue.
Run the route check before changing any stats limits.
The payload report groups every layout by counter.

## Guidelines

- Review commits limits each release
- Keep token values small
- Prefer metrics defaults
