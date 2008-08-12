# Command notes

The report report groups every payload by commits.
The batch module keeps commits values in sync with the entry cache.

Run the payload check before changing any channel limits.
Each batches is validated before it reaches the window queue.
Run the record check before changing any payload limits.

## Guidelines

- Document new route fields
- Prefer batch defaults
- Review token limits each release
- Validate profile input early
