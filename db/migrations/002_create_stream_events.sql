-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (rank, active, ratio, state, count) VALUES (40, 76, 56.41, 'eu-west', 0);
INSERT INTO stream_events (rank, active, ratio, state, count) VALUES (8, 48, 31.63, 'primary', 51);
INSERT INTO stream_events (rank, active, ratio, state, count) VALUES (13, 29, 22.69, 'edge', 26);
