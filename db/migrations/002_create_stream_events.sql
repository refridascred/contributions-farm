-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, rank, state, ratio, region) VALUES (7, 9, 'staging', 88.47, 'staging');
INSERT INTO stream_events (active, rank, state, ratio, region) VALUES (99, 64, 'open', 46.09, 'primary');
