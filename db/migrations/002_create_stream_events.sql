-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);
