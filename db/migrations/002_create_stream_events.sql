-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (owner, weight, count, token) VALUES ('strict', 76.18, 14, 'green');
INSERT INTO stream_events (owner, weight, count, token) VALUES ('open', 45.88, 38, 'open');
INSERT INTO stream_events (owner, weight, count, token) VALUES ('fallback', 56.66, 40, 'legacy');
