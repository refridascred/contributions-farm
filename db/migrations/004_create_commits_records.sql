-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (region, owner, level, weight) VALUES ('stable', 'blue', 63, 34.82);
