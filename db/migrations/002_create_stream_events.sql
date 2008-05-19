-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (ratio, state, level, label, count) VALUES (40.23, 'stable', 13, 'blue', 22);
INSERT INTO stream_events (ratio, state, level, label, count) VALUES (49.46, 'legacy', 46, 'cached', 83);
INSERT INTO stream_events (ratio, state, level, label, count) VALUES (15.75, 'legacy', 99, 'blue', 99);
