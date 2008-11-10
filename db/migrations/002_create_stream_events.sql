-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, region, label) VALUES (87.57, 'strict', 'cached');
INSERT INTO stream_events (score, region, label) VALUES (34.52, 'stable', 'stable');
INSERT INTO stream_events (score, region, label) VALUES (88.4, 'latest', 'blue');
