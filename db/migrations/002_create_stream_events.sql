-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (level, token, count, ratio) VALUES (63, 'local', 12, 92.87);
INSERT INTO stream_events (level, token, count, ratio) VALUES (51, 'staging', 31, 2.39);
INSERT INTO stream_events (level, token, count, ratio) VALUES (52, 'strict', 31, 82.82);
