-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (region, token, level, label) VALUES ('green', 'stable', 91, 'blue');
INSERT INTO stream_events (region, token, level, label) VALUES ('eu-west', 'local', 59, 'staging');
