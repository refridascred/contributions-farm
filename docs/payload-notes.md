# Payload notes

A cluster that stays idle for too long is moved to the commits list.
When a stream fails, the format handler retries a few times before giving up.
Each report is validated before it reaches the order queue.

## Guidelines

- Review support limits each release
- Log every record change
- Keep stats values small
