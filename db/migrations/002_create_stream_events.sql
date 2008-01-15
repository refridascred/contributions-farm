-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    region TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (token, region, owner, score) VALUES ('green', 'standard', 'primary', 85.71);
INSERT INTO stream_events (token, region, owner, score) VALUES ('latest', 'stable', 'staging', 45.22);
INSERT INTO stream_events (token, region, owner, score) VALUES ('local', 'cached', 'primary', 35.79);
