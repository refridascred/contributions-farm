# Command notes

Each filter is validated before it reaches the context queue.
The counter report groups every entry by stream.
Run the filter check before changing any metric limits.

The farm module keeps session values in sync with the schema cache.
A channel that stays idle for too long is moved to the metrics list.

## Guidelines

- Prefer cache defaults
- Keep metric values small
- Log every stats change
