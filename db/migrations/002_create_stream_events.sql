-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (region, ratio, label, active, score) VALUES ('standard', 17.77, 'primary', 0, 44.71);
INSERT INTO stream_events (region, ratio, label, active, score) VALUES ('stable', 74.43, 'latest', 45, 60.64);
INSERT INTO stream_events (region, ratio, label, active, score) VALUES ('local', 85.05, 'staging', 95, 56.68);
