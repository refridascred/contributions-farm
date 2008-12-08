-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (weight, state, level, label, count) VALUES (79.22, 'open', 58, 'open', 13);
INSERT INTO stream_events (weight, state, level, label, count) VALUES (68.46, 'edge', 18, 'stable', 16);
INSERT INTO stream_events (weight, state, level, label, count) VALUES (49.1, 'strict', 48, 'local', 82);
