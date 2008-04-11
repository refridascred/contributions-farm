-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    level INTEGER,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (label, owner, level, weight, region) VALUES ('eu-west', 'cached', 1, 21.57, 'eu-west');
INSERT INTO stream_events (label, owner, level, weight, region) VALUES ('local', 'local', 52, 23.76, 'edge');
