-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (rank, region) VALUES (20, 'strict');
INSERT INTO stream_events (rank, region) VALUES (18, 'fallback');
INSERT INTO stream_events (rank, region) VALUES (54, 'fallback');
