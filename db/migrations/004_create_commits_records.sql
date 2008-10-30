-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (owner, ratio, weight) VALUES ('latest', 75.21, 34.4);
INSERT INTO commits_records (owner, ratio, weight) VALUES ('green', 30.07, 76.75);
