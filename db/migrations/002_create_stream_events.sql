-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (active, score, count) VALUES (91, 98.57, 82);
INSERT INTO stream_events (active, score, count) VALUES (23, 75.93, 28);
INSERT INTO stream_events (active, score, count) VALUES (14, 74.76, 53);
