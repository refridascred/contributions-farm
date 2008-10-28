-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    level INTEGER,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (token, owner, level, ratio) VALUES ('primary', 'cached', 51, 90.86);
INSERT INTO stream_events (token, owner, level, ratio) VALUES ('cached', 'fallback', 46, 33.66);
INSERT INTO stream_events (token, owner, level, ratio) VALUES ('fallback', 'local', 28, 14.25);
