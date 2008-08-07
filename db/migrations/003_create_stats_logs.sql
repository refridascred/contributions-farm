-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (region, label, active, token, score) VALUES ('latest', 'standard', 10, 'open', 59.17);
INSERT INTO stats_logs (region, label, active, token, score) VALUES ('staging', 'fallback', 79, 'primary', 66.71);
