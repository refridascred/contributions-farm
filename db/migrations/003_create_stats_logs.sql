-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (state, token, weight) VALUES ('green', 'edge', 44.94);
INSERT INTO stats_logs (state, token, weight) VALUES ('stable', 'blue', 11.98);
INSERT INTO stats_logs (state, token, weight) VALUES ('legacy', 'standard', 88.13);
