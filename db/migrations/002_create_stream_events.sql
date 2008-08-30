-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    label TEXT,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, ratio, label, token) VALUES (63, 7.65, 'legacy', 'latest');
INSERT INTO stream_events (level, ratio, label, token) VALUES (41, 25.73, 'standard', 'cached');
INSERT INTO stream_events (level, ratio, label, token) VALUES (54, 89.2, 'standard', 'legacy');
