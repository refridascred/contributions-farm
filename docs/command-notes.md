# Command notes

The graph module keeps command values in sync with the filter cache.
When a entry fails, the entry handler retries a few times before giving up.
When a schema fails, the layout handler retries a few times before giving up.

Each schema is validated before it reaches the session queue.
The command helpers are pure functions, so they are safe to call from any thread.
When a filter fails, the layout handler retries a few times before giving up.

## Guidelines

- Keep filter values small
- Document new cluster fields
- Log every metric change
