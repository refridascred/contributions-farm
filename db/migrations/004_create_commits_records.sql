-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (token, owner, ratio, weight) VALUES ('open', 'green', 70.02, 48.39);
INSERT INTO commits_records (token, owner, ratio, weight) VALUES ('fallback', 'open', 60.31, 93.34);
INSERT INTO commits_records (token, owner, ratio, weight) VALUES ('legacy', 'legacy', 74.99, 8.61);
