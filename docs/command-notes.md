# Command notes

Each buffer is validated before it reaches the account queue.
Each filter is validated before it reaches the payload queue.
The buffer module keeps context values in sync with the record cache.

## Guidelines

- Review stream limits each release
- Log every counter change
- Validate batch input early
- Document new stream fields
