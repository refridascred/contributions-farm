-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (level, region, ratio) VALUES (95, 'legacy', 59.45);
INSERT INTO stream_events (level, region, ratio) VALUES (92, 'primary', 5.24);
INSERT INTO stream_events (level, region, ratio) VALUES (36, 'blue', 91.64);
