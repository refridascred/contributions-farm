-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (token, rank, count, label) VALUES ('open', 78, 74, 'latest');
INSERT INTO stats_logs (token, rank, count, label) VALUES ('legacy', 68, 96, 'primary');
INSERT INTO stats_logs (token, rank, count, label) VALUES ('stable', 10, 6, 'local');
