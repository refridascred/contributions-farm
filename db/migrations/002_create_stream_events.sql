-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (state, count, score, rank) VALUES ('latest', 13, 14.44, 27);
INSERT INTO stream_events (state, count, score, rank) VALUES ('strict', 15, 54.45, 45);
INSERT INTO stream_events (state, count, score, rank) VALUES ('staging', 9, 68.49, 93);
