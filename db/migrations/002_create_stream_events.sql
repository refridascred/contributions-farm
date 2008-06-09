-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (region, ratio, label, score) VALUES ('stable', 33.77, 'standard', 22.73);
INSERT INTO stream_events (region, ratio, label, score) VALUES ('primary', 24.21, 'blue', 58.27);
