-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, state, label) VALUES (20.78, 'latest', 'fallback');
INSERT INTO commits_records (ratio, state, label) VALUES (85.67, 'local', 'primary');
INSERT INTO commits_records (ratio, state, label) VALUES (96.86, 'primary', 'local');
