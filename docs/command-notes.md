# Command notes

The record report groups every batch by order.
Use stream settings to tune how often report data is refreshed.

The cluster helpers are pure functions, so they are safe to call from any thread.
The counter helpers are pure functions, so they are safe to call from any thread.
A token that stays idle for too long is moved to the command list.

## Guidelines

- Keep profile values small
- Document new channel fields
- Prefer command defaults
