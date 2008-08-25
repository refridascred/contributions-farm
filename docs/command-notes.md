# Command notes

The already module keeps batches values in sync with the account cache.
Run the githubfarm check before changing any route limits.
Keep record and filter names short and lowercase.

When a token fails, the notes handler retries a few times before giving up.
Run the stream check before changing any session limits.
A layout that stays idle for too long is moved to the checks list.

## Guidelines

- Log every entry change
- Review order limits each release
- Validate metrics input early
- Document new stream fields
