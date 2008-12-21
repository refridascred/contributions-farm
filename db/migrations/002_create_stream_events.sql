-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (token, region, state) VALUES ('eu-west', 'cached', 'fallback');
INSERT INTO stream_events (token, region, state) VALUES ('open', 'staging', 'blue');
INSERT INTO stream_events (token, region, state) VALUES ('legacy', 'stable', 'local');
