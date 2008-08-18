-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (owner, state, ratio, count) VALUES ('blue', 'staging', 58.01, 70);
INSERT INTO stream_events (owner, state, ratio, count) VALUES ('eu-west', 'primary', 62.05, 19);
