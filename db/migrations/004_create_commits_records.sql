-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, level, label, count, state) VALUES (53.2, 29, 'green', 3, 'edge');
INSERT INTO commits_records (ratio, level, label, count, state) VALUES (24.89, 60, 'primary', 1, 'cached');
INSERT INTO commits_records (ratio, level, label, count, state) VALUES (85.31, 80, 'green', 81, 'edge');
