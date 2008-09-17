-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (level, label, score, state) VALUES (96, 'primary', 10.91, 'standard');
INSERT INTO stream_events (level, label, score, state) VALUES (75, 'legacy', 67.6, 'edge');
INSERT INTO stream_events (level, label, score, state) VALUES (16, 'edge', 28.97, 'legacy');
