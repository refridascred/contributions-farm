-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, token, score) VALUES ('open', 'fallback', 20.39);
INSERT INTO stream_events (region, token, score) VALUES ('eu-west', 'cached', 78.08);
