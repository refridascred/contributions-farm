-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (token, score, count, state, rank) VALUES ('eu-west', 50.23, 60, 'primary', 97);
INSERT INTO stream_events (token, score, count, state, rank) VALUES ('primary', 94.18, 98, 'local', 66);
