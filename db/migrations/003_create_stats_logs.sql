-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (score, region, rank, owner) VALUES (15.99, 'cached', 14, 'legacy');
INSERT INTO stats_logs (score, region, rank, owner) VALUES (63.64, 'local', 0, 'open');
INSERT INTO stats_logs (score, region, rank, owner) VALUES (65.9, 'eu-west', 20, 'staging');
