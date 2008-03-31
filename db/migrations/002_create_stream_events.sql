-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (score, rank, state, ratio) VALUES (72.27, 72, 'eu-west', 85.01);
INSERT INTO stream_events (score, rank, state, ratio) VALUES (61.03, 84, 'latest', 74.46);
INSERT INTO stream_events (score, rank, state, ratio) VALUES (31.87, 79, 'edge', 48.91);
