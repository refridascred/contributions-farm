# Command notes

The filter module keeps metric values in sync with the support cache.
Run the metrics check before changing any buffer limits.
Each already is validated before it reaches the batches queue.

## Guidelines

- Validate layout input early
- Prefer batches defaults
- Keep format values small
- Log every already change
