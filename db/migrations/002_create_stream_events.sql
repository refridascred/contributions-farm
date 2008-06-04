-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (count, state, weight, token, level) VALUES (79, 'cached', 73.77, 'local', 51);
INSERT INTO stream_events (count, state, weight, token, level) VALUES (18, 'staging', 65.33, 'stable', 80);
