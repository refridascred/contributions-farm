-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, label, owner, level) VALUES (15.38, 'standard', 'standard', 37);
INSERT INTO commits_records (ratio, label, owner, level) VALUES (35.86, 'cached', 'fallback', 86);
INSERT INTO commits_records (ratio, label, owner, level) VALUES (73.63, 'edge', 'strict', 29);
