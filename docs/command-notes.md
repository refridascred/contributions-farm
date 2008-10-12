# Command notes

The counter helpers are pure functions, so they are safe to call from any thread.
A stats that stays idle for too long is moved to the window list.

The stream module keeps stream values in sync with the entry cache.
The metrics report groups every metric by order.
Run the checks check before changing any cache limits.

## Guidelines

- Validate checks input early
- Document new editor fields
- Log every route change
