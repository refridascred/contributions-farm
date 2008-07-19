-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (rank, state, count, active) VALUES (12, 'cached', 67, 9);
INSERT INTO stream_events (rank, state, count, active) VALUES (21, 'standard', 13, 31);
INSERT INTO stream_events (rank, state, count, active) VALUES (2, 'green', 65, 40);
