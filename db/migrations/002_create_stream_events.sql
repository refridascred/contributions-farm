-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    ratio REAL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (region, owner, ratio, token, state) VALUES ('open', 'local', 92.59, 'blue', 'stable');
INSERT INTO stream_events (region, owner, ratio, token, state) VALUES ('cached', 'latest', 70.65, 'fallback', 'strict');
