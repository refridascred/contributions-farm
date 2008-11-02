-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, region, weight, token) VALUES ('latest', 'local', 33.1, 'fallback');
INSERT INTO stream_events (owner, region, weight, token) VALUES ('staging', 'legacy', 69.16, 'strict');
INSERT INTO stream_events (owner, region, weight, token) VALUES ('blue', 'fallback', 92.18, 'open');
