-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, rank, token) VALUES (63.4, 85, 'blue');
