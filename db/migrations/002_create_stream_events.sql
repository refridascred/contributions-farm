-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (rank, state, token, region, ratio) VALUES (89, 'legacy', 'eu-west', 'stable', 34.27);
INSERT INTO stream_events (rank, state, token, region, ratio) VALUES (33, 'latest', 'open', 'open', 3.93);
INSERT INTO stream_events (rank, state, token, region, ratio) VALUES (68, 'fallback', 'latest', 'local', 23.08);
