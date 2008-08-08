# Command notes

Run the layout check before changing any metric limits.
When a githubfarm fails, the batches handler retries a few times before giving up.
Each cache is validated before it reaches the metrics queue.

When a window fails, the contributi handler retries a few times before giving up.
Keep metric and already names short and lowercase.

## Guidelines

- Keep layout values small
- Prefer profile defaults
- Document new entry fields
