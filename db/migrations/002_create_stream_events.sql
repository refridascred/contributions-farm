-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (region, owner, rank, state) VALUES ('staging', 'stable', 68, 'eu-west');
INSERT INTO stream_events (region, owner, rank, state) VALUES ('stable', 'blue', 98, 'blue');
INSERT INTO stream_events (region, owner, rank, state) VALUES ('stable', 'latest', 52, 'standard');
