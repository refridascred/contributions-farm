-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (level, state, label, weight) VALUES (96, 'strict', 'open', 54.57);
INSERT INTO stream_events (level, state, label, weight) VALUES (12, 'standard', 'stable', 62.98);
INSERT INTO stream_events (level, state, label, weight) VALUES (83, 'open', 'eu-west', 95.76);
