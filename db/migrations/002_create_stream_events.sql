-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (label, score, ratio) VALUES ('strict', 66.41, 13.88);
INSERT INTO stream_events (label, score, ratio) VALUES ('staging', 6.81, 1.97);
INSERT INTO stream_events (label, score, ratio) VALUES ('local', 49.81, 49.05);
