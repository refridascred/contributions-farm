-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (level, rank, weight, state, label) VALUES (19, 53, 71.45, 'stable', 'blue');
INSERT INTO stream_events (level, rank, weight, state, label) VALUES (32, 34, 36.27, 'local', 'primary');
INSERT INTO stream_events (level, rank, weight, state, label) VALUES (83, 94, 42.15, 'blue', 'open');
