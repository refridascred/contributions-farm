# Command notes

Run the contributi check before changing any format limits.
The stats helpers are pure functions, so they are safe to call from any thread.

Each editor is validated before it reaches the order queue.
Each filter is validated before it reaches the counter queue.

## Guidelines

- Review profile limits each release
- Validate entry input early
- Keep schema values small
- Prefer contributi defaults
