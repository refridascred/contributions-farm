-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (score, ratio) VALUES (7.07, 50.23);
INSERT INTO stream_events (score, ratio) VALUES (39.07, 9.58);
INSERT INTO stream_events (score, ratio) VALUES (74.15, 7.93);
