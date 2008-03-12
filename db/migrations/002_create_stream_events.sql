-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (count, region, state, label) VALUES (61, 'green', 'eu-west', 'primary');
INSERT INTO stream_events (count, region, state, label) VALUES (91, 'stable', 'cached', 'fallback');
INSERT INTO stream_events (count, region, state, label) VALUES (12, 'eu-west', 'open', 'blue');
