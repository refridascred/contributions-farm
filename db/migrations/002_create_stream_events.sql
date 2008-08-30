-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, label, count, token) VALUES (45, 'blue', 5, 'blue');
INSERT INTO stream_events (rank, label, count, token) VALUES (5, 'green', 86, 'staging');
INSERT INTO stream_events (rank, label, count, token) VALUES (50, 'standard', 0, 'eu-west');
