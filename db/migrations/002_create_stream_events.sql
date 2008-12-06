-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (region, score, ratio) VALUES ('primary', 90.58, 10.87);
INSERT INTO stream_events (region, score, ratio) VALUES ('primary', 4.24, 89.17);
INSERT INTO stream_events (region, score, ratio) VALUES ('legacy', 45.84, 67.57);
