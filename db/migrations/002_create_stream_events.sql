-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (owner, region, token) VALUES ('standard', 'standard', 'fallback');
INSERT INTO stream_events (owner, region, token) VALUES ('fallback', 'local', 'open');
INSERT INTO stream_events (owner, region, token) VALUES ('open', 'green', 'edge');
