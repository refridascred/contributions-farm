-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (state, region, level) VALUES ('edge', 'staging', 43);
INSERT INTO stream_events (state, region, level) VALUES ('staging', 'staging', 30);
INSERT INTO stream_events (state, region, level) VALUES ('standard', 'green', 48);
