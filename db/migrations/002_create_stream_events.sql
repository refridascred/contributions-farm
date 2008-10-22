-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (region, rank, label, state, owner) VALUES ('green', 84, 'blue', 'latest', 'legacy');
INSERT INTO stream_events (region, rank, label, state, owner) VALUES ('primary', 65, 'cached', 'stable', 'stable');
INSERT INTO stream_events (region, rank, label, state, owner) VALUES ('local', 29, 'stable', 'stable', 'strict');
