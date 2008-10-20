-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (state, count, region) VALUES ('local', 71, 'eu-west');
INSERT INTO stream_events (state, count, region) VALUES ('eu-west', 44, 'eu-west');
INSERT INTO stream_events (state, count, region) VALUES ('standard', 90, 'blue');
