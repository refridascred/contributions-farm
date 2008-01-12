-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (region, active, state) VALUES ('open', 67, 'primary');
INSERT INTO stream_events (region, active, state) VALUES ('edge', 45, 'blue');
INSERT INTO stream_events (region, active, state) VALUES ('blue', 56, 'cached');
