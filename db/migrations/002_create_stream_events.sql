-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, active, label, weight, token) VALUES (12, 33, 'blue', 79.93, 'eu-west');
INSERT INTO stream_events (rank, active, label, weight, token) VALUES (5, 74, 'blue', 66.21, 'cached');
