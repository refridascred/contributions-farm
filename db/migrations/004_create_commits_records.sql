-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (level, label, active, ratio) VALUES (32, 'primary', 91, 61.12);
INSERT INTO commits_records (level, label, active, ratio) VALUES (99, 'open', 3, 2.74);
