-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (ratio, level, owner) VALUES (63.03, 16, 'green');
INSERT INTO stream_events (ratio, level, owner) VALUES (61.4, 40, 'latest');
INSERT INTO stream_events (ratio, level, owner) VALUES (95.54, 75, 'local');
