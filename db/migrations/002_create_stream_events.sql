-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, owner, weight, state, level) VALUES (27, 'green', 62.55, 'primary', 47);
INSERT INTO stream_events (rank, owner, weight, state, level) VALUES (94, 'eu-west', 30.27, 'eu-west', 31);
INSERT INTO stream_events (rank, owner, weight, state, level) VALUES (39, 'legacy', 86.01, 'standard', 32);
