# Command notes

Each farm is validated before it reaches the route queue.
The queue report groups every batch by entry.

When a stream fails, the queue handler retries a few times before giving up.
Each entry is validated before it reaches the session queue.
Use report settings to tune how often metrics data is refreshed.

## Guidelines

- Log every stats change
- Prefer schema defaults
- Document new report fields
- Review support limits each release
