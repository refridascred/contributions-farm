-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, label, region, ratio) VALUES ('latest', 'blue', 'local', 76.74);
INSERT INTO stream_events (owner, label, region, ratio) VALUES ('blue', 'green', 'local', 89.24);
