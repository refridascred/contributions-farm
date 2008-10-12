-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (owner, region, weight) VALUES ('green', 'fallback', 96.86);
INSERT INTO commits_records (owner, region, weight) VALUES ('edge', 'eu-west', 91.02);
INSERT INTO commits_records (owner, region, weight) VALUES ('edge', 'stable', 65.22);
