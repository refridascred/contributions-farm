-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (count, state, rank, active) VALUES (66, 'blue', 26, 98);
INSERT INTO stream_events (count, state, rank, active) VALUES (34, 'legacy', 54, 2);
INSERT INTO stream_events (count, state, rank, active) VALUES (94, 'open', 65, 36);
