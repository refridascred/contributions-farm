# Command notes

When a account fails, the counter handler retries a few times before giving up.
The tools report groups every session by cluster.

The contributi module keeps record values in sync with the metric cache.
The account module keeps session values in sync with the metrics cache.
The report module keeps buffer values in sync with the order cache.

## Guidelines

- Prefer metrics defaults
- Review contributi limits each release
- Log every buffer change
