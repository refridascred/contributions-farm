-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    token TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (ratio, level, token, score) VALUES (51.26, 38, 'primary', 56.27);
INSERT INTO stream_events (ratio, level, token, score) VALUES (45.88, 91, 'primary', 98.54);
INSERT INTO stream_events (ratio, level, token, score) VALUES (54.97, 84, 'strict', 63.93);
