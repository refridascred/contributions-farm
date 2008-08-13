-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (state, token, level, ratio) VALUES ('primary', 'fallback', 54, 66.44);
INSERT INTO stream_events (state, token, level, ratio) VALUES ('legacy', 'edge', 80, 72.53);
INSERT INTO stream_events (state, token, level, ratio) VALUES ('blue', 'legacy', 5, 92.81);
