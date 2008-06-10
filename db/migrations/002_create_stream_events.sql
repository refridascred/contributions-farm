-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (owner, weight, count, state) VALUES ('strict', 48.6, 17, 'latest');
INSERT INTO stream_events (owner, weight, count, state) VALUES ('local', 52.68, 35, 'standard');
