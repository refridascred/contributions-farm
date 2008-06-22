-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (level, state, token, ratio) VALUES (34, 'fallback', 'green', 79.94);
INSERT INTO stream_events (level, state, token, ratio) VALUES (2, 'local', 'strict', 79.03);
