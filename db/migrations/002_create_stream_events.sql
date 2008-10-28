-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (level, rank, active, ratio, state) VALUES (62, 39, 24, 64.43, 'stable');
INSERT INTO stream_events (level, rank, active, ratio, state) VALUES (29, 0, 4, 95.98, 'staging');
