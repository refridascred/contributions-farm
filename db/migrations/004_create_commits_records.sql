-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, label, score) VALUES (96, 'edge', 76.76);
INSERT INTO commits_records (level, label, score) VALUES (85, 'primary', 62.37);
INSERT INTO commits_records (level, label, score) VALUES (68, 'legacy', 25.89);
