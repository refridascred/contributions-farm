-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (level, label, ratio, state, count) VALUES (42, 'eu-west', 1.41, 'open', 20);
INSERT INTO stream_events (level, label, ratio, state, count) VALUES (47, 'staging', 67.41, 'blue', 55);
