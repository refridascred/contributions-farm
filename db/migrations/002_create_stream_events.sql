-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    created_at TIMESTAMP,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (owner, label, rank, state) VALUES ('cached', 'legacy', 78, 'staging');
INSERT INTO stream_events (owner, label, rank, state) VALUES ('eu-west', 'primary', 6, 'fallback');
INSERT INTO stream_events (owner, label, rank, state) VALUES ('legacy', 'eu-west', 19, 'staging');
