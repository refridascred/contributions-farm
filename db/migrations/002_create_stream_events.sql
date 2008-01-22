-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, state, region) VALUES (90, 'cached', 'blue');
INSERT INTO stream_events (level, state, region) VALUES (70, 'legacy', 'primary');
INSERT INTO stream_events (level, state, region) VALUES (12, 'staging', 'legacy');
