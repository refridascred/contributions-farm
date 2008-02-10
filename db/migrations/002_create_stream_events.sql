-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (weight, rank, owner, state) VALUES (21.67, 20, 'cached', 'standard');
INSERT INTO stream_events (weight, rank, owner, state) VALUES (10.64, 30, 'local', 'cached');
INSERT INTO stream_events (weight, rank, owner, state) VALUES (11.61, 83, 'stable', 'local');
