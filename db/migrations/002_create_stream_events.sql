-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (ratio, rank, state, label) VALUES (65.59, 71, 'staging', 'staging');
INSERT INTO stream_events (ratio, rank, state, label) VALUES (5.55, 89, 'latest', 'standard');
