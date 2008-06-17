-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (owner, token, state, region, ratio) VALUES ('primary', 'blue', 'fallback', 'latest', 15.96);
INSERT INTO stream_events (owner, token, state, region, ratio) VALUES ('primary', 'green', 'staging', 'local', 68.26);
