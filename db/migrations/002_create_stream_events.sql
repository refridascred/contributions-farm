-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (count, rank, label) VALUES (8, 51, 'eu-west');
INSERT INTO stream_events (count, rank, label) VALUES (45, 27, 'blue');
INSERT INTO stream_events (count, rank, label) VALUES (71, 32, 'staging');
