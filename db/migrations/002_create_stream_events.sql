-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (rank, state, count, owner, region) VALUES (72, 'blue', 11, 'standard', 'green');
INSERT INTO stream_events (rank, state, count, owner, region) VALUES (32, 'standard', 59, 'primary', 'cached');
INSERT INTO stream_events (rank, state, count, owner, region) VALUES (7, 'edge', 94, 'fallback', 'strict');
