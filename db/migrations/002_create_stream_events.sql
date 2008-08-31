-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (label, count, state, weight) VALUES ('green', 59, 'standard', 64.54);
INSERT INTO stream_events (label, count, state, weight) VALUES ('legacy', 40, 'cached', 60.3);
INSERT INTO stream_events (label, count, state, weight) VALUES ('local', 38, 'open', 87.82);
