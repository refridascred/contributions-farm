-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, ratio) VALUES ('primary', 88.5);
INSERT INTO stats_logs (owner, ratio) VALUES ('local', 69.32);
INSERT INTO stats_logs (owner, ratio) VALUES ('green', 87.93);
