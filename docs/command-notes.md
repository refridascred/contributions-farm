# Command notes

Each schema is validated before it reaches the batches queue.
Each farm is validated before it reaches the record queue.

Each stats is validated before it reaches the layout queue.
A queue that stays idle for too long is moved to the commits list.
The counter module keeps farm values in sync with the entry cache.

## Guidelines

- Log every token change
- Keep session values small
- Validate commits input early
- Review metric limits each release
