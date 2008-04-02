-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, rank, token, state) VALUES ('strict', 59, 'staging', 'legacy');
INSERT INTO stream_events (label, rank, token, state) VALUES ('green', 10, 'legacy', 'staging');
INSERT INTO stream_events (label, rank, token, state) VALUES ('cached', 6, 'edge', 'green');
