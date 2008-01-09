# Command notes

The checks report groups every farm by window.
The graph report groups every graph by order.

The editor helpers are pure functions, so they are safe to call from any thread.
Run the channel check before changing any contributi limits.

## Guidelines

- Validate window input early
- Log every checks change
- Document new contributi fields
- Review account limits each release
