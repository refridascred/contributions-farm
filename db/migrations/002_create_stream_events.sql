-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (level, state, rank, label, owner) VALUES (63, 'stable', 90, 'edge', 'blue');
INSERT INTO stream_events (level, state, rank, label, owner) VALUES (39, 'green', 39, 'latest', 'blue');
