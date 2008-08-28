-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (label, level, region) VALUES ('blue', 45, 'eu-west');
INSERT INTO stream_events (label, level, region) VALUES ('legacy', 64, 'open');
