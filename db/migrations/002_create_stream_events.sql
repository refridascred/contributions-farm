-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (score, region, label) VALUES (63.16, 'green', 'eu-west');
INSERT INTO stream_events (score, region, label) VALUES (92.92, 'blue', 'local');
INSERT INTO stream_events (score, region, label) VALUES (78.89, 'green', 'green');
