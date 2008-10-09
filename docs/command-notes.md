# Command notes

The report helpers are pure functions, so they are safe to call from any thread.
Keep layout and cache names short and lowercase.

The checks report groups every session by githubfarm.
The githubfarm module keeps batches values in sync with the stream cache.

## Guidelines

- Document new report fields
- Log every filter change
- Prefer profile defaults
- Keep channel values small
