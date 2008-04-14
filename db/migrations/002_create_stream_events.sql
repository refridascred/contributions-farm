-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (region, rank, score) VALUES ('staging', 65, 66.81);
INSERT INTO stream_events (region, rank, score) VALUES ('fallback', 6, 32.2);
INSERT INTO stream_events (region, rank, score) VALUES ('local', 42, 96.97);
