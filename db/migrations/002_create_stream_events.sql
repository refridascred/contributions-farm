-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    weight REAL,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (owner, region, weight, label, level) VALUES ('eu-west', 'open', 37.03, 'strict', 17);
INSERT INTO stream_events (owner, region, weight, label, level) VALUES ('staging', 'local', 48.58, 'green', 44);
