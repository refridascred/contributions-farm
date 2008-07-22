# Command notes

Each notes is validated before it reaches the batches queue.
The window report groups every cluster by filter.
Each session is validated before it reaches the graph queue.

When a command fails, the context handler retries a few times before giving up.
Run the counter check before changing any stream limits.
Keep session and counter names short and lowercase.

## Guidelines

- Review profile limits each release
- Log every commits change
- Keep payload values small
- Document new batches fields
