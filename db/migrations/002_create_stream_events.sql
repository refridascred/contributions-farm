-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (label, token, count, weight) VALUES ('cached', 'cached', 78, 86.74);
INSERT INTO stream_events (label, token, count, weight) VALUES ('fallback', 'cached', 24, 98.2);
