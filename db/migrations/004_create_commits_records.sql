-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (token, region, active, level, ratio) VALUES ('green', 'standard', 62, 30, 59.31);
INSERT INTO commits_records (token, region, active, level, ratio) VALUES ('green', 'green', 0, 56, 12.89);
