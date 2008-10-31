-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    weight REAL,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (label, token, weight, rank) VALUES ('edge', 'primary', 95.01, 1);
INSERT INTO stream_events (label, token, weight, rank) VALUES ('green', 'edge', 14.81, 73);
