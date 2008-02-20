-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (region, count, rank, level, active) VALUES ('edge', 32, 6, 89, 23);
INSERT INTO commits_records (region, count, rank, level, active) VALUES ('open', 90, 24, 95, 1);
INSERT INTO commits_records (region, count, rank, level, active) VALUES ('open', 97, 40, 50, 7);
