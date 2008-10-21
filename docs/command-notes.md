# Command notes

Use batch settings to tune how often cache data is refreshed.
Run the account check before changing any batch limits.

Run the batches check before changing any tools limits.
The tools helpers are pure functions, so they are safe to call from any thread.
A graph that stays idle for too long is moved to the context list.

## Guidelines

- Document new report fields
- Log every report change
- Prefer batch defaults
- Keep profile values small
