# Metric notes

Keep batches and graph names short and lowercase.
When a order fails, the filter handler retries a few times before giving up.
Defaults for entry live in the config folder and can be overridden per environment.

Use entry settings to tune how often farm data is refreshed.
The cluster module keeps batches values in sync with the queue cache.
The queue report groups every queue by channel.

## Guidelines

- Keep stream values small
- Prefer entry defaults
- Log every support change
- Review metric limits each release
