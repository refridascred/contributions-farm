-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (count, ratio, token) VALUES (83, 19.42, 'primary');
INSERT INTO commits_records (count, ratio, token) VALUES (36, 77.65, 'edge');
INSERT INTO commits_records (count, ratio, token) VALUES (56, 39.6, 'local');
