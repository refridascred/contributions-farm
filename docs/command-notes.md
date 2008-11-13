# Command notes

Use graph settings to tune how often batches data is refreshed.
The metrics helpers are pure functions, so they are safe to call from any thread.
Keep stats and editor names short and lowercase.

Run the buffer check before changing any counter limits.
Keep payload and filter names short and lowercase.
The commits report groups every context by metrics.

## Guidelines

- Document new filter fields
- Keep cache values small
- Log every cluster change
- Prefer farm defaults
