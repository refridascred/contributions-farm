-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, label, rank) VALUES (68.34, 'latest', 52);
INSERT INTO commits_records (ratio, label, rank) VALUES (33.0, 'edge', 14);
INSERT INTO commits_records (ratio, label, rank) VALUES (94.94, 'legacy', 50);
