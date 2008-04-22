-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, weight, owner, state) VALUES (67, 50.0, 'edge', 'staging');
INSERT INTO stream_events (count, weight, owner, state) VALUES (17, 34.8, 'green', 'local');
INSERT INTO stream_events (count, weight, owner, state) VALUES (89, 17.48, 'strict', 'strict');
