-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (score, token, count) VALUES (80.42, 'standard', 92);
INSERT INTO stream_events (score, token, count) VALUES (44.27, 'primary', 43);
INSERT INTO stream_events (score, token, count) VALUES (86.36, 'green', 82);
