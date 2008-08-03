-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (level, owner, score, count, label) VALUES (97, 'strict', 65.1, 57, 'eu-west');
INSERT INTO stream_events (level, owner, score, count, label) VALUES (28, 'stable', 49.92, 24, 'stable');
INSERT INTO stream_events (level, owner, score, count, label) VALUES (75, 'green', 60.79, 69, 'fallback');
