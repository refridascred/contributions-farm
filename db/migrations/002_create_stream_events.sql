-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (rank, label, weight, count) VALUES (62, 'green', 73.44, 4);
INSERT INTO stream_events (rank, label, weight, count) VALUES (25, 'eu-west', 75.95, 32);
INSERT INTO stream_events (rank, label, weight, count) VALUES (80, 'local', 51.78, 88);
