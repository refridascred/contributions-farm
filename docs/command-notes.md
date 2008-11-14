# Command notes

The buffer module keeps profile values in sync with the payload cache.
Keep format and metric names short and lowercase.
Keep buffer and stream names short and lowercase.

A cluster that stays idle for too long is moved to the format list.
When a batch fails, the notes handler retries a few times before giving up.
Each record is validated before it reaches the command queue.

## Guidelines

- Prefer queue defaults
- Validate farm input early
- Document new graph fields
