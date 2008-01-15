-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    token TEXT,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, region, token, owner, ratio) VALUES (80, 'primary', 'strict', 'primary', 36.4);
INSERT INTO stream_events (count, region, token, owner, ratio) VALUES (30, 'green', 'local', 'staging', 73.41);
INSERT INTO stream_events (count, region, token, owner, ratio) VALUES (82, 'cached', 'green', 'staging', 72.53);
