# Command notes

When a cache fails, the window handler retries a few times before giving up.
A window that stays idle for too long is moved to the queue list.

The batch report groups every cluster by already.
A route that stays idle for too long is moved to the command list.
The counter module keeps metric values in sync with the command cache.

## Guidelines

- Log every record change
- Document new commits fields
- Validate batches input early
