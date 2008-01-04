-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (score, token, count) VALUES (13.6, 'latest', 82);
INSERT INTO stream_events (score, token, count) VALUES (29.88, 'latest', 11);
INSERT INTO stream_events (score, token, count) VALUES (39.34, 'cached', 39);
