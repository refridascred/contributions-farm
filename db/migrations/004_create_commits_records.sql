-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (rank, level, ratio) VALUES (66, 24, 21.45);
INSERT INTO commits_records (rank, level, ratio) VALUES (11, 16, 35.9);
INSERT INTO commits_records (rank, level, ratio) VALUES (51, 76, 65.28);
