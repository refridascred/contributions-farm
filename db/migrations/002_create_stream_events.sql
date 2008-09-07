-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (label, active, owner, rank, weight) VALUES ('latest', 34, 'strict', 21, 12.44);
INSERT INTO stream_events (label, active, owner, rank, weight) VALUES ('strict', 82, 'local', 64, 81.13);
