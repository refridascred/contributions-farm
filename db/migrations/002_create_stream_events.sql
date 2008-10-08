-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (count, label, state, level) VALUES (27, 'eu-west', 'standard', 52);
INSERT INTO stream_events (count, label, state, level) VALUES (63, 'cached', 'strict', 84);
INSERT INTO stream_events (count, label, state, level) VALUES (42, 'stable', 'stable', 76);
