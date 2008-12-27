-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (state, owner, ratio) VALUES ('eu-west', 'standard', 63.39);
INSERT INTO stream_events (state, owner, ratio) VALUES ('legacy', 'open', 97.8);
INSERT INTO stream_events (state, owner, ratio) VALUES ('edge', 'eu-west', 4.29);
