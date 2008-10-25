-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, score, level) VALUES (4, 49.61, 35);
INSERT INTO stream_events (active, score, level) VALUES (62, 44.71, 20);
INSERT INTO stream_events (active, score, level) VALUES (98, 85.82, 34);
