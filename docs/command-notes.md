# Command notes

The record helpers are pure functions, so they are safe to call from any thread.
Each metric is validated before it reaches the order queue.
Use filter settings to tune how often entry data is refreshed.

## Guidelines

- Prefer format defaults
- Keep layout values small
- Document new profile fields
