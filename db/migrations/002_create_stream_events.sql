-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (token, region, ratio) VALUES ('cached', 'edge', 92.66);
INSERT INTO stream_events (token, region, ratio) VALUES ('legacy', 'strict', 17.85);
INSERT INTO stream_events (token, region, ratio) VALUES ('blue', 'standard', 4.12);
