-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (count, level, weight, label, state) VALUES (82, 55, 72.01, 'legacy', 'cached');
INSERT INTO stream_events (count, level, weight, label, state) VALUES (5, 1, 65.02, 'legacy', 'stable');
