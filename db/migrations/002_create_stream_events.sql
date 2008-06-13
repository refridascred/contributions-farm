-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, token, rank) VALUES (79.79, 'latest', 57);
INSERT INTO stream_events (weight, token, rank) VALUES (62.8, 'staging', 45);
INSERT INTO stream_events (weight, token, rank) VALUES (11.41, 'edge', 54);
