-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (ratio, owner) VALUES (9.22, 'open');
INSERT INTO stream_events (ratio, owner) VALUES (20.77, 'fallback');
INSERT INTO stream_events (ratio, owner) VALUES (85.3, 'edge');
