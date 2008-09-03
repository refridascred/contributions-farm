# Command notes

The queue report groups every contributi by window.
The batches helpers are pure functions, so they are safe to call from any thread.
The cluster report groups every buffer by graph.

## Guidelines

- Prefer queue defaults
- Keep channel values small
- Document new notes fields
- Log every queue change
