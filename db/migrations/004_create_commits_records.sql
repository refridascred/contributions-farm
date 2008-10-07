-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (owner, level, count, region, weight) VALUES ('eu-west', 34, 30, 'legacy', 82.4);
INSERT INTO commits_records (owner, level, count, region, weight) VALUES ('open', 78, 56, 'legacy', 23.13);
INSERT INTO commits_records (owner, level, count, region, weight) VALUES ('latest', 44, 48, 'blue', 59.05);
