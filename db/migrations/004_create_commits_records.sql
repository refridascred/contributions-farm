-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (active, ratio, count, weight, rank) VALUES (22, 81.24, 86, 93.58, 91);
INSERT INTO commits_records (active, ratio, count, weight, rank) VALUES (88, 32.04, 34, 81.17, 79);
INSERT INTO commits_records (active, ratio, count, weight, rank) VALUES (53, 34.34, 22, 56.01, 15);
