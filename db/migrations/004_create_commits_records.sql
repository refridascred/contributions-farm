-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (rank, level, ratio, owner) VALUES (72, 27, 95.49, 'edge');
INSERT INTO commits_records (rank, level, ratio, owner) VALUES (8, 84, 40.19, 'staging');
