-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (weight, rank, label, token) VALUES (0.04, 57, 'stable', 'latest');
INSERT INTO stream_events (weight, rank, label, token) VALUES (78.22, 29, 'standard', 'staging');
