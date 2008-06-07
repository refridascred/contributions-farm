-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, score, label, owner) VALUES (21.6, 70.8, 'eu-west', 'green');
INSERT INTO stream_events (weight, score, label, owner) VALUES (22.28, 55.22, 'primary', 'legacy');
INSERT INTO stream_events (weight, score, label, owner) VALUES (74.29, 51.75, 'staging', 'staging');
