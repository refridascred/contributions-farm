-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (state, level, active, ratio, label) VALUES ('blue', 64, 52, 42.52, 'latest');
INSERT INTO commits_records (state, level, active, ratio, label) VALUES ('latest', 59, 13, 65.8, 'stable');
INSERT INTO commits_records (state, level, active, ratio, label) VALUES ('local', 14, 51, 54.08, 'local');
