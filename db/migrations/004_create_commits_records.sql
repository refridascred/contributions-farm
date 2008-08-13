-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (state, owner, ratio, score, region) VALUES ('primary', 'primary', 86.67, 69.5, 'green');
INSERT INTO commits_records (state, owner, ratio, score, region) VALUES ('edge', 'open', 19.79, 23.37, 'latest');
