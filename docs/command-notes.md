# Command notes

The batches report groups every channel by counter.
The counter module keeps batches values in sync with the account cache.
When a payload fails, the filter handler retries a few times before giving up.

## Guidelines

- Keep session values small
- Log every githubfarm change
- Validate order input early
- Document new notes fields
