-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (region, label, score, ratio) VALUES ('blue', 'blue', 25.41, 64.3);
INSERT INTO stream_events (region, label, score, ratio) VALUES ('edge', 'green', 30.88, 73.45);
INSERT INTO stream_events (region, label, score, ratio) VALUES ('staging', 'green', 75.81, 32.29);
