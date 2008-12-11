-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (region, score, ratio) VALUES ('local', 5.46, 52.06);
INSERT INTO stream_events (region, score, ratio) VALUES ('local', 35.63, 69.27);
INSERT INTO stream_events (region, score, ratio) VALUES ('primary', 93.95, 83.17);
