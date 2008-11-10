-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (weight, label, rank) VALUES (51.99, 'local', 55);
INSERT INTO stream_events (weight, label, rank) VALUES (60.36, 'stable', 76);
INSERT INTO stream_events (weight, label, rank) VALUES (10.5, 'open', 73);
