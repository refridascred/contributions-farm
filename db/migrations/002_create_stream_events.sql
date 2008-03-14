-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (count, active, score) VALUES (17, 14, 49.26);
INSERT INTO stream_events (count, active, score) VALUES (49, 62, 70.45);
INSERT INTO stream_events (count, active, score) VALUES (53, 39, 63.31);
