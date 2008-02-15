-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (level, count, weight, owner) VALUES (62, 44, 24.88, 'eu-west');
INSERT INTO commits_records (level, count, weight, owner) VALUES (78, 79, 54.36, 'open');
INSERT INTO commits_records (level, count, weight, owner) VALUES (41, 30, 44.42, 'blue');
