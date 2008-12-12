-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, label, ratio) VALUES ('cached', 'eu-west', 95.13);
INSERT INTO stats_logs (owner, label, ratio) VALUES ('edge', 'latest', 68.88);
INSERT INTO stats_logs (owner, label, ratio) VALUES ('legacy', 'legacy', 27.23);
