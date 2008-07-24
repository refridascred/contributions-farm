# Command notes

When a editor fails, the channel handler retries a few times before giving up.
When a command fails, the stats handler retries a few times before giving up.
The record helpers are pure functions, so they are safe to call from any thread.

Run the record check before changing any metric limits.
A farm that stays idle for too long is moved to the checks list.

## Guidelines

- Validate report input early
- Keep metric values small
- Log every checks change
- Review cache limits each release
