-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (rank, state, label, level, owner) VALUES (3, 'staging', 'staging', 54, 'standard');
INSERT INTO stream_events (rank, state, label, level, owner) VALUES (34, 'latest', 'primary', 63, 'stable');
