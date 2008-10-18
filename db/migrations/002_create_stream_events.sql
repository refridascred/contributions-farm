-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (state, level, token, region) VALUES ('legacy', 88, 'staging', 'strict');
INSERT INTO stream_events (state, level, token, region) VALUES ('staging', 27, 'open', 'strict');
