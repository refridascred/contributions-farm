-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    level INTEGER,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (rank, weight, level, label, state) VALUES (54, 52.11, 68, 'edge', 'local');
INSERT INTO stream_events (rank, weight, level, label, state) VALUES (58, 55.74, 15, 'local', 'standard');
INSERT INTO stream_events (rank, weight, level, label, state) VALUES (76, 84.75, 32, 'staging', 'blue');
