-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (token, count, level) VALUES ('open', 66, 78);
INSERT INTO stream_events (token, count, level) VALUES ('cached', 79, 77);
INSERT INTO stream_events (token, count, level) VALUES ('local', 65, 23);
