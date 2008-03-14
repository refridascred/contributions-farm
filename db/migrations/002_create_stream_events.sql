-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (weight, level, state, ratio) VALUES (64.43, 11, 'open', 16.6);
INSERT INTO stream_events (weight, level, state, ratio) VALUES (48.18, 30, 'blue', 63.37);
