# Command notes

A layout that stays idle for too long is moved to the order list.
Each editor is validated before it reaches the batches queue.

Run the batch check before changing any profile limits.
The metrics module keeps command values in sync with the layout cache.
The counter module keeps batches values in sync with the tools cache.

## Guidelines

- Keep token values small
- Prefer context defaults
- Validate tools input early
