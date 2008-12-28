-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, state, level) VALUES (85, 'standard', 83);
INSERT INTO stream_events (rank, state, level) VALUES (0, 'strict', 6);
INSERT INTO stream_events (rank, state, level) VALUES (90, 'open', 9);
