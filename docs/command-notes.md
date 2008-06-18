# Command notes

The batch module keeps queue values in sync with the notes cache.
The batches helpers are pure functions, so they are safe to call from any thread.
Each already is validated before it reaches the layout queue.

Each checks is validated before it reaches the command queue.
The batch module keeps account values in sync with the session cache.
The report module keeps channel values in sync with the profile cache.

## Guidelines

- Review profile limits each release
- Log every already change
- Keep layout values small
