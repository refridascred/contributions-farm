-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (score, level, state) VALUES (83.16, 46, 'stable');
INSERT INTO stream_events (score, level, state) VALUES (19.15, 57, 'cached');
INSERT INTO stream_events (score, level, state) VALUES (92.34, 77, 'cached');
