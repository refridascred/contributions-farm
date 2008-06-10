-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (state, count, level) VALUES ('local', 36, 36);
INSERT INTO stream_events (state, count, level) VALUES ('eu-west', 66, 16);
INSERT INTO stream_events (state, count, level) VALUES ('fallback', 8, 30);
