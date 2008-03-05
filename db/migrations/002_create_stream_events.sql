-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (owner, weight, active, state) VALUES ('standard', 13.09, 82, 'primary');
INSERT INTO stream_events (owner, weight, active, state) VALUES ('local', 4.0, 87, 'open');
INSERT INTO stream_events (owner, weight, active, state) VALUES ('legacy', 96.32, 48, 'legacy');
