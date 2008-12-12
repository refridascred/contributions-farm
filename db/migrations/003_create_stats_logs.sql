-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, rank) VALUES ('standard', 1);
INSERT INTO stats_logs (state, rank) VALUES ('fallback', 23);
INSERT INTO stats_logs (state, rank) VALUES ('cached', 65);
