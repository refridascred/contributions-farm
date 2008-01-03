-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (region, token, level, label) VALUES ('primary', 'cached', 26, 'open');
INSERT INTO stream_events (region, token, level, label) VALUES ('blue', 'legacy', 42, 'local');
INSERT INTO stream_events (region, token, level, label) VALUES ('staging', 'latest', 47, 'primary');
