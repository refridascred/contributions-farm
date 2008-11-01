-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (token, owner, weight, region) VALUES ('fallback', 'green', 64.86, 'strict');
INSERT INTO stream_events (token, owner, weight, region) VALUES ('staging', 'local', 52.29, 'fallback');
