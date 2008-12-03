-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (state, count, owner, token, ratio) VALUES ('stable', 42, 'latest', 'open', 3.8);
INSERT INTO stream_events (state, count, owner, token, ratio) VALUES ('fallback', 21, 'stable', 'local', 91.84);
INSERT INTO stream_events (state, count, owner, token, ratio) VALUES ('latest', 19, 'primary', 'legacy', 77.38);
