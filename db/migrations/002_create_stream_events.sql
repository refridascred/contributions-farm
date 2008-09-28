-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (score, level, state) VALUES (26.24, 17, 'latest');
INSERT INTO stream_events (score, level, state) VALUES (34.34, 16, 'fallback');
INSERT INTO stream_events (score, level, state) VALUES (46.81, 90, 'stable');
