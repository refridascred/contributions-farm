-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (region, count, state, level) VALUES ('standard', 66, 'edge', 60);
INSERT INTO stream_events (region, count, state, level) VALUES ('staging', 75, 'cached', 19);
INSERT INTO stream_events (region, count, state, level) VALUES ('staging', 37, 'primary', 46);
