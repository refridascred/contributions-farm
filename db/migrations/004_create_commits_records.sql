-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (rank, ratio, level) VALUES (93, 68.44, 96);
INSERT INTO commits_records (rank, ratio, level) VALUES (94, 54.82, 53);
