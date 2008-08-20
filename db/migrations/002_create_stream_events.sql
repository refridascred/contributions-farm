-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (region, rank, label, token) VALUES ('edge', 51, 'open', 'strict');
INSERT INTO stream_events (region, rank, label, token) VALUES ('standard', 47, 'strict', 'fallback');
