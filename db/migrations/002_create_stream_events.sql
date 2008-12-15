-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (score, ratio, level, state) VALUES (60.25, 94.36, 63, 'fallback');
INSERT INTO stream_events (score, ratio, level, state) VALUES (72.1, 97.55, 55, 'primary');
INSERT INTO stream_events (score, ratio, level, state) VALUES (18.9, 96.43, 2, 'local');
