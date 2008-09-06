-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (count, active, weight, rank, token) VALUES (72, 36, 95.87, 75, 'eu-west');
INSERT INTO stream_events (count, active, weight, rank, token) VALUES (81, 37, 16.44, 98, 'standard');
