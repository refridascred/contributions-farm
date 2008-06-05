-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (region, rank, state, token, count) VALUES ('cached', 5, 'blue', 'green', 48);
INSERT INTO stream_events (region, rank, state, token, count) VALUES ('edge', 41, 'eu-west', 'edge', 8);
INSERT INTO stream_events (region, rank, state, token, count) VALUES ('latest', 9, 'legacy', 'open', 56);
