-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    level INTEGER,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (token, weight, level, owner, region) VALUES ('eu-west', 76.72, 14, 'latest', 'latest');
INSERT INTO commits_records (token, weight, level, owner, region) VALUES ('standard', 43.83, 50, 'stable', 'staging');
INSERT INTO commits_records (token, weight, level, owner, region) VALUES ('open', 87.59, 53, 'blue', 'latest');
