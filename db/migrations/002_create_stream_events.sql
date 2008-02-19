-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (state, level, region) VALUES ('open', 12, 'eu-west');
INSERT INTO stream_events (state, level, region) VALUES ('blue', 22, 'cached');
