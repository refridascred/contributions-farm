-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (level, ratio, owner, region) VALUES (67, 33.68, 'standard', 'green');
INSERT INTO commits_records (level, ratio, owner, region) VALUES (0, 5.57, 'open', 'blue');
