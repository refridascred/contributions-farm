# Command notes

The channel helpers are pure functions, so they are safe to call from any thread.
When a batch fails, the contributi handler retries a few times before giving up.

A account that stays idle for too long is moved to the queue list.
A counter that stays idle for too long is moved to the support list.
The metric report groups every order by tools.

## Guidelines

- Document new payload fields
- Log every layout change
- Prefer token defaults
