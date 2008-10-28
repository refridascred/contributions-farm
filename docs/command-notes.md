# Command notes

The queue report groups every payload by record.
The order module keeps tools values in sync with the buffer cache.
When a payload fails, the stream handler retries a few times before giving up.

The support module keeps profile values in sync with the format cache.
The entry module keeps account values in sync with the entry cache.

## Guidelines

- Prefer channel defaults
- Document new cluster fields
- Log every record change
