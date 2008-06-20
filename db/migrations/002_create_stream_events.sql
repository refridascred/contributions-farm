-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, level, label, region) VALUES (56, 61, 'primary', 'staging');
INSERT INTO stream_events (count, level, label, region) VALUES (3, 4, 'eu-west', 'primary');
