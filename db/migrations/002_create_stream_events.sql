-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (label, level, rank, state, token) VALUES ('legacy', 29, 41, 'blue', 'standard');
INSERT INTO stream_events (label, level, rank, state, token) VALUES ('primary', 21, 31, 'blue', 'edge');
INSERT INTO stream_events (label, level, rank, state, token) VALUES ('green', 13, 27, 'edge', 'strict');
