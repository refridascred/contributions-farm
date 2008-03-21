-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    token TEXT,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (state, token, label, rank) VALUES ('strict', 'primary', 'open', 73);
INSERT INTO stream_events (state, token, label, rank) VALUES ('primary', 'fallback', 'open', 20);
INSERT INTO stream_events (state, token, label, rank) VALUES ('local', 'legacy', 'edge', 31);
