-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    region TEXT,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (token, rank, region, weight, level) VALUES ('staging', 81, 'strict', 95.21, 55);
INSERT INTO commits_records (token, rank, region, weight, level) VALUES ('standard', 10, 'stable', 94.12, 76);
