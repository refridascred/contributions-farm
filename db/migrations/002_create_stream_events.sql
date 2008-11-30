-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (rank, label, ratio) VALUES (94, 'legacy', 56.0);
INSERT INTO stream_events (rank, label, ratio) VALUES (89, 'latest', 74.53);
