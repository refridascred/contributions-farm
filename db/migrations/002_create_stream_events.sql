-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, region, score) VALUES ('stable', 'eu-west', 93.62);
INSERT INTO stream_events (label, region, score) VALUES ('eu-west', 'strict', 58.13);
INSERT INTO stream_events (label, region, score) VALUES ('latest', 'fallback', 35.54);
