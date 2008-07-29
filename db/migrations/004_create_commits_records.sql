-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (weight, ratio, score, count, owner) VALUES (28.81, 71.65, 97.2, 6, 'latest');
INSERT INTO commits_records (weight, ratio, score, count, owner) VALUES (53.28, 96.25, 30.93, 37, 'primary');
