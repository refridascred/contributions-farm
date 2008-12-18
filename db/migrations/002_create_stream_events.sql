-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (token, score, level, rank) VALUES ('staging', 63.1, 66, 32);
INSERT INTO stream_events (token, score, level, rank) VALUES ('cached', 30.5, 71, 55);
INSERT INTO stream_events (token, score, level, rank) VALUES ('open', 96.78, 40, 60);
