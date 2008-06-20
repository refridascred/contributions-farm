-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (owner, weight, active, rank) VALUES ('strict', 11.99, 60, 15);
INSERT INTO stream_events (owner, weight, active, rank) VALUES ('cached', 65.54, 96, 14);
