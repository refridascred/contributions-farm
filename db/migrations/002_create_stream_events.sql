-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (label, weight, score, level) VALUES ('strict', 8.44, 13.72, 4);
INSERT INTO stream_events (label, weight, score, level) VALUES ('legacy', 80.41, 64.97, 88);
