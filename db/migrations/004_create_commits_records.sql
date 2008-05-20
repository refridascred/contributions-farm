-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (level, ratio, active, label) VALUES (53, 63.74, 62, 'legacy');
INSERT INTO commits_records (level, ratio, active, label) VALUES (96, 27.64, 94, 'cached');
INSERT INTO commits_records (level, ratio, active, label) VALUES (20, 0.45, 26, 'staging');
