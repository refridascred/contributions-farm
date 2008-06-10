# Command notes

The stream module keeps profile values in sync with the queue cache.
The channel module keeps checks values in sync with the order cache.

Run the command check before changing any account limits.
Each buffer is validated before it reaches the schema queue.
The context module keeps session values in sync with the metrics cache.

## Guidelines

- Document new checks fields
- Log every channel change
- Validate payload input early
