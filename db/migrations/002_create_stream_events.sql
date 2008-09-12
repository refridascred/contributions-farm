-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, label, token, score, weight) VALUES ('blue', 'local', 'eu-west', 46.03, 36.72);
INSERT INTO stream_events (region, label, token, score, weight) VALUES ('standard', 'legacy', 'legacy', 93.32, 51.4);
