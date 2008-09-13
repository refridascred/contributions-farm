-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, weight, rank, state, token) VALUES (16, 27.57, 9, 'latest', 'local');
INSERT INTO stream_events (count, weight, rank, state, token) VALUES (63, 5.48, 9, 'edge', 'primary');
