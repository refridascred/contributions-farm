-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, weight, state) VALUES (53, 73.35, 'stable');
INSERT INTO stream_events (count, weight, state) VALUES (92, 21.32, 'staging');
INSERT INTO stream_events (count, weight, state) VALUES (38, 24.29, 'cached');
