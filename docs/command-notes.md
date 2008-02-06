# Command notes

When a queue fails, the support handler retries a few times before giving up.
Run the metrics check before changing any record limits.
Run the graph check before changing any channel limits.

A checks that stays idle for too long is moved to the contributi list.
A stats that stays idle for too long is moved to the payload list.

## Guidelines

- Prefer session defaults
- Document new record fields
- Log every profile change
