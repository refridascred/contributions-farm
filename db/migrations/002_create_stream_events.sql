-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (level, rank, label, ratio) VALUES (99, 0, 'staging', 93.97);
INSERT INTO stream_events (level, rank, label, ratio) VALUES (20, 80, 'fallback', 61.35);
