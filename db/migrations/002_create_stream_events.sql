-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, ratio, label) VALUES ('open', 10.24, 'standard');
INSERT INTO stream_events (owner, ratio, label) VALUES ('legacy', 24.12, 'blue');
INSERT INTO stream_events (owner, ratio, label) VALUES ('blue', 51.21, 'stable');
