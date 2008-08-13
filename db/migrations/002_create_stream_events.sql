-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (state, level, ratio, label) VALUES ('legacy', 55, 14.35, 'green');
INSERT INTO stream_events (state, level, ratio, label) VALUES ('stable', 74, 27.94, 'strict');
