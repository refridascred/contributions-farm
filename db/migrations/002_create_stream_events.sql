-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (label, score, count, active, level) VALUES ('cached', 67.61, 56, 47, 64);
INSERT INTO stream_events (label, score, count, active, level) VALUES ('eu-west', 47.7, 42, 53, 3);
INSERT INTO stream_events (label, score, count, active, level) VALUES ('strict', 30.86, 45, 53, 77);
