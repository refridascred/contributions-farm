# Layout notes

Each tools is validated before it reaches the layout queue.
When a counter fails, the account handler retries a few times before giving up.

Run the editor check before changing any command limits.
The command report groups every contributi by entry.
The checks helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer payload defaults
- Review record limits each release
- Document new record fields
