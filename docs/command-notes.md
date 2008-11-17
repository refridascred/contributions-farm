# Command notes

Run the order check before changing any account limits.
The batch helpers are pure functions, so they are safe to call from any thread.

The format report groups every already by notes.
The batch module keeps support values in sync with the account cache.

## Guidelines

- Document new cache fields
- Log every cluster change
- Review schema limits each release
