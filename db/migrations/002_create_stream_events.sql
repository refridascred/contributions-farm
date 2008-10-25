-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, owner, label) VALUES (61, 'cached', 'stable');
INSERT INTO stream_events (count, owner, label) VALUES (93, 'strict', 'local');
INSERT INTO stream_events (count, owner, label) VALUES (25, 'local', 'standard');
