-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (rank, score, token, state, region) VALUES (42, 29.64, 'fallback', 'blue', 'staging');
INSERT INTO stream_events (rank, score, token, state, region) VALUES (90, 4.98, 'primary', 'staging', 'standard');
