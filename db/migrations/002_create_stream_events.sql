-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (ratio, owner, level) VALUES (76.47, 'local', 5);
INSERT INTO stream_events (ratio, owner, level) VALUES (73.12, 'staging', 59);
INSERT INTO stream_events (ratio, owner, level) VALUES (48.6, 'blue', 75);
