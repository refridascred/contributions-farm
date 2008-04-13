-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, level, owner) VALUES (84, 18, 'legacy');
INSERT INTO commits_records (count, level, owner) VALUES (36, 45, 'latest');
INSERT INTO commits_records (count, level, owner) VALUES (44, 7, 'local');
