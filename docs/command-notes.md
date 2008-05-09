# Command notes

Keep stream and order names short and lowercase.
The contributi module keeps metrics values in sync with the stream cache.
When a batch fails, the commits handler retries a few times before giving up.

Each githubfarm is validated before it reaches the route queue.
Use session settings to tune how often format data is refreshed.

## Guidelines

- Keep profile values small
- Validate cache input early
- Document new contributi fields
- Log every githubfarm change
