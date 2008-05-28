-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (region, level, label, owner) VALUES ('green', 5, 'open', 'eu-west');
INSERT INTO stream_events (region, level, label, owner) VALUES ('stable', 55, 'cached', 'staging');
INSERT INTO stream_events (region, level, label, owner) VALUES ('eu-west', 83, 'primary', 'latest');
