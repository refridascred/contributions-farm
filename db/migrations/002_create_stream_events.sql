-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (weight, rank, active, label) VALUES (42.77, 19, 14, 'latest');
INSERT INTO stream_events (weight, rank, active, label) VALUES (32.39, 73, 62, 'legacy');
