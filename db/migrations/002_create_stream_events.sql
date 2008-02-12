-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    level INTEGER,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (owner, region, level, token, label) VALUES ('stable', 'cached', 73, 'blue', 'blue');
INSERT INTO stream_events (owner, region, level, token, label) VALUES ('edge', 'cached', 38, 'legacy', 'green');
INSERT INTO stream_events (owner, region, level, token, label) VALUES ('cached', 'latest', 53, 'local', 'open');
