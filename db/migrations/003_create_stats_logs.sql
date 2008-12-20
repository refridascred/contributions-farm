-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (owner, active, count, token, weight) VALUES ('legacy', 95, 85, 'open', 4.0);
INSERT INTO stats_logs (owner, active, count, token, weight) VALUES ('blue', 21, 85, 'legacy', 13.12);
INSERT INTO stats_logs (owner, active, count, token, weight) VALUES ('standard', 48, 22, 'latest', 73.92);
