-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (state, rank, owner, region) VALUES ('fallback', 54, 'staging', 'green');
INSERT INTO stream_events (state, rank, owner, region) VALUES ('green', 63, 'fallback', 'fallback');
