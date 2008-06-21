-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, level, score) VALUES (74, 5, 33.15);
INSERT INTO stream_events (active, level, score) VALUES (38, 77, 96.23);
INSERT INTO stream_events (active, level, score) VALUES (4, 24, 75.44);
