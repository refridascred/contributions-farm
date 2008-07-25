-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (rank, weight, state, ratio) VALUES (98, 66.85, 'legacy', 92.51);
INSERT INTO stream_events (rank, weight, state, ratio) VALUES (55, 68.76, 'green', 28.08);
INSERT INTO stream_events (rank, weight, state, ratio) VALUES (33, 48.55, 'stable', 22.64);
