-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (token, ratio, label, state) VALUES ('primary', 65.6, 'edge', 'stable');
INSERT INTO commits_records (token, ratio, label, state) VALUES ('green', 92.13, 'cached', 'blue');
INSERT INTO commits_records (token, ratio, label, state) VALUES ('blue', 79.49, 'legacy', 'green');
