-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (score, weight, token, region) VALUES (81.57, 77.94, 'eu-west', 'standard');
INSERT INTO stream_events (score, weight, token, region) VALUES (77.62, 41.03, 'strict', 'local');
