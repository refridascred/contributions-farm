-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (owner, weight, token) VALUES ('primary', 16.6, 'fallback');
INSERT INTO stream_events (owner, weight, token) VALUES ('legacy', 10.38, 'edge');
