-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (rank, owner, weight, state) VALUES (0, 'strict', 15.47, 'blue');
INSERT INTO stream_events (rank, owner, weight, state) VALUES (21, 'stable', 31.13, 'primary');
