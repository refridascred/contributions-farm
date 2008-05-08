-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (region, rank, ratio, count, active) VALUES ('primary', 40, 54.64, 78, 56);
INSERT INTO commits_records (region, rank, ratio, count, active) VALUES ('open', 19, 66.45, 11, 49);
