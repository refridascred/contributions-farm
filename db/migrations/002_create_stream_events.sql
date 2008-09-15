-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, token, owner) VALUES ('standard', 'cached', 'blue');
INSERT INTO stream_events (region, token, owner) VALUES ('eu-west', 'blue', 'fallback');
INSERT INTO stream_events (region, token, owner) VALUES ('blue', 'fallback', 'open');
