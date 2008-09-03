# Command notes

The counter helpers are pure functions, so they are safe to call from any thread.
Run the commits check before changing any schema limits.
A channel that stays idle for too long is moved to the support list.

The order report groups every already by order.
A entry that stays idle for too long is moved to the profile list.
A already that stays idle for too long is moved to the schema list.

## Guidelines

- Validate cluster input early
- Review layout limits each release
- Document new cache fields
- Keep stats values small
