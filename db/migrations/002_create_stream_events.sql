-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    region TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, owner, region, ratio, count) VALUES ('latest', 'primary', 'staging', 22.67, 92);
INSERT INTO stream_events (state, owner, region, ratio, count) VALUES ('edge', 'standard', 'local', 39.85, 1);
