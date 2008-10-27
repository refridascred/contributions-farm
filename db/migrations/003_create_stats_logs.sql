-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (state, rank) VALUES ('stable', 47);
INSERT INTO stats_logs (state, rank) VALUES ('legacy', 18);
INSERT INTO stats_logs (state, rank) VALUES ('edge', 71);
