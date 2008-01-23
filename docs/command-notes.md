# Command notes

Each window is validated before it reaches the layout queue.
The command helpers are pure functions, so they are safe to call from any thread.
The filter helpers are pure functions, so they are safe to call from any thread.

Each stats is validated before it reaches the payload queue.
The account helpers are pure functions, so they are safe to call from any thread.
The batches report groups every counter by payload.

## Guidelines

- Validate notes input early
- Keep checks values small
- Log every queue change
- Document new farm fields
