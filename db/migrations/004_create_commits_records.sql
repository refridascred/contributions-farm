-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (level, rank, ratio) VALUES (84, 66, 79.26);
INSERT INTO commits_records (level, rank, ratio) VALUES (8, 94, 39.42);
