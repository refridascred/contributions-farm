-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (active, level, count, score, label) VALUES (99, 32, 16, 96.98, 'legacy');
INSERT INTO stream_events (active, level, count, score, label) VALUES (86, 21, 22, 48.94, 'legacy');
INSERT INTO stream_events (active, level, count, score, label) VALUES (91, 23, 45, 97.19, 'legacy');
