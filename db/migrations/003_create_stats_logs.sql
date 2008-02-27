-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, label, region, rank) VALUES ('stable', 'cached', 'legacy', 93);
INSERT INTO stats_logs (owner, label, region, rank) VALUES ('legacy', 'local', 'blue', 65);
