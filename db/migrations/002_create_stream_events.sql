-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, count, token) VALUES (46.78, 41, 'open');
INSERT INTO stream_events (weight, count, token) VALUES (40.72, 93, 'staging');
INSERT INTO stream_events (weight, count, token) VALUES (52.4, 62, 'staging');
