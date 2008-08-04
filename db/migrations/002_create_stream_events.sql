-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, rank, token) VALUES (34.82, 62, 'legacy');
INSERT INTO stream_events (ratio, rank, token) VALUES (58.81, 67, 'primary');
INSERT INTO stream_events (ratio, rank, token) VALUES (26.72, 69, 'fallback');
