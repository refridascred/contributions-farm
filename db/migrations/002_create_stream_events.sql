-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (count, label, state) VALUES (12, 'open', 'legacy');
INSERT INTO stream_events (count, label, state) VALUES (22, 'open', 'staging');
INSERT INTO stream_events (count, label, state) VALUES (71, 'strict', 'edge');
