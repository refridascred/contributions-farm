-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (owner, label, level, region) VALUES ('eu-west', 'open', 27, 'cached');
INSERT INTO stream_events (owner, label, level, region) VALUES ('cached', 'legacy', 30, 'legacy');
