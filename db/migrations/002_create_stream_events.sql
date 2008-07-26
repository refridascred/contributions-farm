-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, state, label, region) VALUES (78, 'legacy', 'open', 'local');
INSERT INTO stream_events (count, state, label, region) VALUES (35, 'primary', 'open', 'eu-west');
INSERT INTO stream_events (count, state, label, region) VALUES (4, 'eu-west', 'open', 'stable');
