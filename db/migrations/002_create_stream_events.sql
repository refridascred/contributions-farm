-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (state, level, score, label, count) VALUES ('fallback', 37, 64.77, 'eu-west', 6);
INSERT INTO stream_events (state, level, score, label, count) VALUES ('blue', 36, 88.4, 'standard', 22);
