# Command notes

Run the route check before changing any cache limits.
The tools report groups every window by cache.
When a payload fails, the stats handler retries a few times before giving up.

Each cluster is validated before it reaches the window queue.
Run the order check before changing any stats limits.
Keep filter and filter names short and lowercase.

## Guidelines

- Validate tools input early
- Document new farm fields
- Log every batch change
- Review payload limits each release
