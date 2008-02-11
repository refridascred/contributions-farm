-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (label, weight, token, count) VALUES ('cached', 27.36, 'local', 71);
INSERT INTO stream_events (label, weight, token, count) VALUES ('cached', 19.26, 'stable', 95);
