-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (token, owner, count, level) VALUES ('cached', 'blue', 37, 44);
INSERT INTO stream_events (token, owner, count, level) VALUES ('legacy', 'stable', 30, 27);
INSERT INTO stream_events (token, owner, count, level) VALUES ('primary', 'cached', 93, 73);
