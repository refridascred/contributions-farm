-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (weight, owner, ratio) VALUES (4.36, 'open', 82.01);
INSERT INTO commits_records (weight, owner, ratio) VALUES (43.29, 'blue', 96.05);
