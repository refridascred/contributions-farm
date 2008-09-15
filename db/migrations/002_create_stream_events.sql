-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (owner, ratio, state, label, weight) VALUES ('stable', 56.38, 'fallback', 'standard', 64.51);
INSERT INTO stream_events (owner, ratio, state, label, weight) VALUES ('primary', 58.33, 'staging', 'primary', 14.28);
INSERT INTO stream_events (owner, ratio, state, label, weight) VALUES ('open', 30.48, 'staging', 'latest', 31.94);
