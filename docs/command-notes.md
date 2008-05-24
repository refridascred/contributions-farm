# Command notes

Each batches is validated before it reaches the context queue.
The account report groups every filter by queue.
Each cache is validated before it reaches the channel queue.

The payload module keeps contributi values in sync with the metric cache.
The schema module keeps contributi values in sync with the support cache.

## Guidelines

- Document new filter fields
- Keep checks values small
- Prefer queue defaults
