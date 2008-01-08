-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (region, label, level, token) VALUES ('open', 'strict', 16, 'legacy');
INSERT INTO stream_events (region, label, level, token) VALUES ('blue', 'local', 21, 'fallback');
