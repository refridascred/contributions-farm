# Command notes

Keep report and already names short and lowercase.
Run the queue check before changing any support limits.
When a metric fails, the commits handler retries a few times before giving up.

Keep metric and queue names short and lowercase.
A batches that stays idle for too long is moved to the metric list.
Each tools is validated before it reaches the stream queue.

## Guidelines

- Keep token values small
- Validate stats input early
- Document new cluster fields
- Log every channel change
