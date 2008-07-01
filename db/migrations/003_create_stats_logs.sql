-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (region, active, token, score, state) VALUES ('edge', 13, 'latest', 18.03, 'edge');
INSERT INTO stats_logs (region, active, token, score, state) VALUES ('blue', 81, 'strict', 75.19, 'primary');
INSERT INTO stats_logs (region, active, token, score, state) VALUES ('standard', 79, 'standard', 45.17, 'staging');
