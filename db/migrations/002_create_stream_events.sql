-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, owner, label) VALUES (66.88, 'strict', 'eu-west');
INSERT INTO stream_events (weight, owner, label) VALUES (76.35, 'strict', 'strict');
INSERT INTO stream_events (weight, owner, label) VALUES (98.78, 'cached', 'legacy');
