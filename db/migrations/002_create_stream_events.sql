-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (region, token, state, weight, rank) VALUES ('cached', 'stable', 'edge', 44.3, 78);
INSERT INTO stream_events (region, token, state, weight, rank) VALUES ('strict', 'blue', 'open', 33.82, 42);
