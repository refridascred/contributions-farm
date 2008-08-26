-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (ratio, token, owner, region) VALUES (75.99, 'open', 'open', 'local');
INSERT INTO stream_events (ratio, token, owner, region) VALUES (7.43, 'stable', 'standard', 'cached');
INSERT INTO stream_events (ratio, token, owner, region) VALUES (32.99, 'standard', 'legacy', 'primary');
