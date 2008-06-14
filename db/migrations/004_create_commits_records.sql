-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, score, state) VALUES (91.67, 28.63, 'standard');
INSERT INTO commits_records (ratio, score, state) VALUES (23.99, 70.51, 'green');
INSERT INTO commits_records (ratio, score, state) VALUES (91.41, 8.25, 'stable');
