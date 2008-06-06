# Command notes

When a metrics fails, the support handler retries a few times before giving up.
The buffer module keeps command values in sync with the tools cache.
A window that stays idle for too long is moved to the notes list.

The profile module keeps buffer values in sync with the batch cache.
Each report is validated before it reaches the record queue.
The checks module keeps layout values in sync with the stream cache.

## Guidelines

- Validate metrics input early
- Keep stats values small
- Prefer window defaults
