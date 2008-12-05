# Command notes

The cluster report groups every notes by buffer.
The stats report groups every batches by stream.
Each batches is validated before it reaches the report queue.

The editor report groups every buffer by metric.
The window module keeps metric values in sync with the contributi cache.
The filter module keeps channel values in sync with the profile cache.

## Guidelines

- Log every filter change
- Keep metrics values small
- Review batches limits each release
- Validate account input early
