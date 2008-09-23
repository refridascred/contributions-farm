-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (count, state, weight, token, label) VALUES (17, 'primary', 23.37, 'legacy', 'staging');
INSERT INTO stream_events (count, state, weight, token, label) VALUES (81, 'edge', 29.99, 'cached', 'legacy');
