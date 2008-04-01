-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    weight REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, token, weight, label, state) VALUES (37.53, 'primary', 87.42, 'fallback', 'legacy');
INSERT INTO stream_events (ratio, token, weight, label, state) VALUES (6.08, 'local', 24.63, 'blue', 'green');
