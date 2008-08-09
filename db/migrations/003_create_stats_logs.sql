-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (region, rank, owner, label) VALUES ('cached', 93, 'latest', 'green');
INSERT INTO stats_logs (region, rank, owner, label) VALUES ('legacy', 38, 'eu-west', 'legacy');
INSERT INTO stats_logs (region, rank, owner, label) VALUES ('edge', 9, 'edge', 'standard');
