-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, state, rank, weight) VALUES ('strict', 'staging', 36, 23.4);
INSERT INTO stats_logs (token, state, rank, weight) VALUES ('staging', 'staging', 71, 63.7);
