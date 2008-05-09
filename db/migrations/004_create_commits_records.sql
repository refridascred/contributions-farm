-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (count, level, weight, owner) VALUES (14, 46, 7.61, 'local');
INSERT INTO commits_records (count, level, weight, owner) VALUES (42, 44, 7.5, 'blue');
INSERT INTO commits_records (count, level, weight, owner) VALUES (54, 9, 62.26, 'local');
