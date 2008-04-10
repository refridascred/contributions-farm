-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (region, weight, token, owner) VALUES ('green', 63.79, 'green', 'primary');
INSERT INTO commits_records (region, weight, token, owner) VALUES ('green', 13.14, 'staging', 'cached');
INSERT INTO commits_records (region, weight, token, owner) VALUES ('staging', 90.19, 'primary', 'strict');
