-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (level, label, score, active, ratio) VALUES (14, 'edge', 47.22, 41, 57.74);
INSERT INTO commits_records (level, label, score, active, ratio) VALUES (84, 'open', 77.13, 3, 81.09);
