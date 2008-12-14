-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, label, rank) VALUES (57.31, 'fallback', 10);
INSERT INTO commits_records (ratio, label, rank) VALUES (81.82, 'standard', 33);
INSERT INTO commits_records (ratio, label, rank) VALUES (45.71, 'staging', 90);
