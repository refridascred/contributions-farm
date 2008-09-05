-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    label TEXT,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, region, label, level, rank) VALUES ('local', 'staging', 'legacy', 92, 89);
INSERT INTO stream_events (token, region, label, level, rank) VALUES ('strict', 'blue', 'cached', 75, 84);
