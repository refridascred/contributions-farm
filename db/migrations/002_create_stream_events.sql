-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    rank INTEGER,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (state, token, rank, ratio, active) VALUES ('primary', 'stable', 54, 91.58, 73);
INSERT INTO stream_events (state, token, rank, ratio, active) VALUES ('stable', 'edge', 61, 89.42, 12);
