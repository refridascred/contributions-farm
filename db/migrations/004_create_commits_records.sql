-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (rank, ratio, level) VALUES (38, 94.72, 70);
INSERT INTO commits_records (rank, ratio, level) VALUES (71, 6.54, 87);
