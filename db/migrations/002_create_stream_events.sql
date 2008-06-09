-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (token, level, ratio) VALUES ('legacy', 17, 93.65);
INSERT INTO stream_events (token, level, ratio) VALUES ('standard', 90, 53.81);
INSERT INTO stream_events (token, level, ratio) VALUES ('fallback', 34, 44.33);
