-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (owner, count, ratio) VALUES ('latest', 58, 20.59);
INSERT INTO stats_logs (owner, count, ratio) VALUES ('eu-west', 96, 17.22);
INSERT INTO stats_logs (owner, count, ratio) VALUES ('primary', 64, 52.94);
