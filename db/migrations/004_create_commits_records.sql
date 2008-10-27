-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    owner TEXT NOT NULL,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (rank, weight, owner, level, region) VALUES (91, 3.06, 'cached', 91, 'local');
