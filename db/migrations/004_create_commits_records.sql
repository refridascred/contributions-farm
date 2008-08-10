-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (label, active, region, ratio, level) VALUES ('edge', 13, 'fallback', 59.73, 69);
INSERT INTO commits_records (label, active, region, ratio, level) VALUES ('blue', 19, 'standard', 16.06, 59);
INSERT INTO commits_records (label, active, region, ratio, level) VALUES ('legacy', 25, 'open', 76.09, 12);
