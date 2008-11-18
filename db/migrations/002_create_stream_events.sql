-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (state, rank, ratio, score) VALUES ('strict', 45, 76.61, 16.71);
INSERT INTO stream_events (state, rank, ratio, score) VALUES ('open', 39, 48.61, 67.6);
