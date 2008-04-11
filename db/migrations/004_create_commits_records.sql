-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (weight, owner, region, count, active) VALUES (96.78, 'latest', 'cached', 26, 59);
INSERT INTO commits_records (weight, owner, region, count, active) VALUES (61.49, 'green', 'primary', 97, 66);
INSERT INTO commits_records (weight, owner, region, count, active) VALUES (74.18, 'eu-west', 'eu-west', 67, 49);
