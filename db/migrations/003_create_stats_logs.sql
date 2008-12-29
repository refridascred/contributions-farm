-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (score, active, ratio) VALUES (46.65, 79, 73.65);
INSERT INTO stats_logs (score, active, ratio) VALUES (52.25, 87, 5.04);
INSERT INTO stats_logs (score, active, ratio) VALUES (38.68, 83, 3.68);
