-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (ratio, rank, token) VALUES (61.95, 84, 'fallback');
INSERT INTO stream_events (ratio, rank, token) VALUES (33.25, 10, 'stable');
INSERT INTO stream_events (ratio, rank, token) VALUES (97.2, 75, 'legacy');
