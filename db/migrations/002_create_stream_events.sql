-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (region, active, rank, label) VALUES ('latest', 91, 56, 'eu-west');
