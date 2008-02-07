-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (level, ratio, state, label) VALUES (1, 81.56, 'edge', 'primary');
INSERT INTO commits_records (level, ratio, state, label) VALUES (71, 26.19, 'local', 'primary');
