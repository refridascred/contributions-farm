-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (rank, active, ratio) VALUES (57, 13, 62.17);
INSERT INTO commits_records (rank, active, ratio) VALUES (57, 60, 36.75);
INSERT INTO commits_records (rank, active, ratio) VALUES (75, 8, 95.78);
