-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (region, label, token, count, score) VALUES ('primary', 'eu-west', 'edge', 39, 79.98);
INSERT INTO stream_events (region, label, token, count, score) VALUES ('blue', 'edge', 'cached', 4, 89.52);
INSERT INTO stream_events (region, label, token, count, score) VALUES ('legacy', 'local', 'open', 5, 93.88);
