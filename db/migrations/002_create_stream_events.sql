-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (owner, ratio, count, region) VALUES ('open', 14.59, 43, 'staging');
INSERT INTO stream_events (owner, ratio, count, region) VALUES ('staging', 87.93, 60, 'standard');
