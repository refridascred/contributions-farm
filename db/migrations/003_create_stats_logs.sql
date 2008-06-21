-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (token, label, rank, count, region) VALUES ('legacy', 'eu-west', 5, 21, 'legacy');
INSERT INTO stats_logs (token, label, rank, count, region) VALUES ('stable', 'green', 82, 19, 'staging');
INSERT INTO stats_logs (token, label, rank, count, region) VALUES ('open', 'green', 15, 12, 'strict');
