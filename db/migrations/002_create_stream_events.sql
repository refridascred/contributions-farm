-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (token, level, ratio) VALUES ('staging', 83, 7.02);
INSERT INTO stream_events (token, level, ratio) VALUES ('local', 55, 36.49);
INSERT INTO stream_events (token, level, ratio) VALUES ('green', 49, 88.35);
