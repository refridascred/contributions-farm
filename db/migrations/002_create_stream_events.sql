-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (ratio, token, weight, score) VALUES (65.98, 'green', 58.61, 81.16);
INSERT INTO stream_events (ratio, token, weight, score) VALUES (52.04, 'cached', 67.5, 38.17);
INSERT INTO stream_events (ratio, token, weight, score) VALUES (38.83, 'standard', 12.4, 68.0);
