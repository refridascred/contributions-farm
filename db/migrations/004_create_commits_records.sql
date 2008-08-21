-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (owner, ratio, weight, count) VALUES ('eu-west', 47.47, 80.58, 4);
INSERT INTO commits_records (owner, ratio, weight, count) VALUES ('eu-west', 88.59, 35.38, 2);
INSERT INTO commits_records (owner, ratio, weight, count) VALUES ('local', 23.95, 6.28, 36);
