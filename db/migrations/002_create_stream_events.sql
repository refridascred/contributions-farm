-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (level, state, label) VALUES (9, 'eu-west', 'local');
INSERT INTO stream_events (level, state, label) VALUES (40, 'blue', 'open');
INSERT INTO stream_events (level, state, label) VALUES (7, 'green', 'legacy');
