-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, state, rank, active, level) VALUES (1, 'blue', 25, 13, 95);
INSERT INTO stream_events (count, state, rank, active, level) VALUES (4, 'primary', 20, 20, 12);
INSERT INTO stream_events (count, state, rank, active, level) VALUES (42, 'edge', 91, 9, 23);
