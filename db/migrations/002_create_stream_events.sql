-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, token, active, region) VALUES (73, 'legacy', 46, 'edge');
INSERT INTO stream_events (rank, token, active, region) VALUES (75, 'fallback', 65, 'staging');
INSERT INTO stream_events (rank, token, active, region) VALUES (39, 'standard', 92, 'fallback');
