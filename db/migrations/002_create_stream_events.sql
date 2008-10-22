-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (score, active, count) VALUES (26.63, 12, 92);
INSERT INTO stream_events (score, active, count) VALUES (85.96, 39, 5);
INSERT INTO stream_events (score, active, count) VALUES (68.41, 97, 69);
