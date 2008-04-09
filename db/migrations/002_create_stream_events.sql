-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (level, active, ratio, score, state) VALUES (71, 81, 98.96, 91.88, 'fallback');
INSERT INTO stream_events (level, active, ratio, score, state) VALUES (61, 25, 11.61, 66.11, 'latest');
