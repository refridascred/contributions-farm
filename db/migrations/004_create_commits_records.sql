-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (ratio, level, state) VALUES (5.29, 30, 'green');
INSERT INTO commits_records (ratio, level, state) VALUES (88.14, 37, 'edge');
INSERT INTO commits_records (ratio, level, state) VALUES (88.48, 56, 'strict');
