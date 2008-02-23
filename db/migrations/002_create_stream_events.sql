-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, token, owner) VALUES (85.17, 'stable', 'fallback');
INSERT INTO stream_events (weight, token, owner) VALUES (82.97, 'primary', 'latest');
INSERT INTO stream_events (weight, token, owner) VALUES (35.02, 'cached', 'eu-west');
