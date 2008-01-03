-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, label, ratio, token) VALUES (33, 'fallback', 29.13, 'edge');
INSERT INTO stream_events (rank, label, ratio, token) VALUES (69, 'eu-west', 28.0, 'latest');
