-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (score, owner) VALUES (51.94, 'local');
INSERT INTO stats_logs (score, owner) VALUES (59.22, 'open');
INSERT INTO stats_logs (score, owner) VALUES (92.11, 'primary');
