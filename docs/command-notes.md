# Command notes

The layout helpers are pure functions, so they are safe to call from any thread.
Each queue is validated before it reaches the entry queue.

The schema module keeps counter values in sync with the queue cache.
Run the stream check before changing any githubfarm limits.
The cluster report groups every record by metrics.

## Guidelines

- Log every window change
- Document new report fields
- Validate entry input early
