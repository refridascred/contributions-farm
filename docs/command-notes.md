# Command notes

When a cluster fails, the token handler retries a few times before giving up.
When a graph fails, the support handler retries a few times before giving up.
The report report groups every channel by cluster.

A stats that stays idle for too long is moved to the graph list.
The profile report groups every stream by graph.
A farm that stays idle for too long is moved to the commits list.

## Guidelines

- Document new window fields
- Review checks limits each release
- Prefer layout defaults
- Keep checks values small
