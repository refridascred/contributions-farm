-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (weight, region, state, rank, owner) VALUES (20.11, 'staging', 'open', 78, 'latest');
INSERT INTO stream_events (weight, region, state, rank, owner) VALUES (53.44, 'stable', 'fallback', 10, 'standard');
INSERT INTO stream_events (weight, region, state, rank, owner) VALUES (33.24, 'latest', 'strict', 56, 'open');
