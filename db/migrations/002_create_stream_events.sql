-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (token, active, rank, count, state) VALUES ('blue', 78, 80, 10, 'latest');
INSERT INTO stream_events (token, active, rank, count, state) VALUES ('local', 45, 33, 87, 'blue');
INSERT INTO stream_events (token, active, rank, count, state) VALUES ('strict', 65, 69, 81, 'stable');
