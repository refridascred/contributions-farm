-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (label, count, level, active, score) VALUES ('local', 3, 76, 77, 25.07);
INSERT INTO stream_events (label, count, level, active, score) VALUES ('strict', 83, 36, 11, 50.97);
INSERT INTO stream_events (label, count, level, active, score) VALUES ('primary', 98, 30, 7, 25.24);
