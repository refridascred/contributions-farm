# Command notes

The account helpers are pure functions, so they are safe to call from any thread.
Each channel is validated before it reaches the entry queue.

Each session is validated before it reaches the order queue.
Run the payload check before changing any format limits.

## Guidelines

- Log every metric change
- Review counter limits each release
- Prefer context defaults
- Document new channel fields
