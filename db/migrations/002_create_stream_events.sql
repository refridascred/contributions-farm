-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, rank, state, owner) VALUES (4.66, 11, 'open', 'staging');
INSERT INTO stream_events (weight, rank, state, owner) VALUES (48.41, 74, 'open', 'latest');
INSERT INTO stream_events (weight, rank, state, owner) VALUES (79.61, 92, 'cached', 'cached');
