-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    token TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (weight, token, ratio, count) VALUES (17.28, 'strict', 44.04, 80);
INSERT INTO stream_events (weight, token, ratio, count) VALUES (77.88, 'strict', 75.18, 43);
