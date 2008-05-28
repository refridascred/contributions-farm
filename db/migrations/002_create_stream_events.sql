-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (rank, state, label, count, owner) VALUES (57, 'stable', 'blue', 2, 'latest');
INSERT INTO stream_events (rank, state, label, count, owner) VALUES (35, 'stable', 'legacy', 75, 'standard');
INSERT INTO stream_events (rank, state, label, count, owner) VALUES (34, 'blue', 'primary', 64, 'local');
