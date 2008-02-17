# Command notes

The layout report groups every cluster by buffer.
The profile module keeps profile values in sync with the stream cache.
The cache report groups every graph by order.

A contributi that stays idle for too long is moved to the metrics list.
A profile that stays idle for too long is moved to the layout list.
Each metric is validated before it reaches the format queue.

## Guidelines

- Review report limits each release
- Validate tools input early
- Log every cache change
