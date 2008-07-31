-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (label, level, ratio) VALUES ('open', 99, 48.95);
INSERT INTO commits_records (label, level, ratio) VALUES ('legacy', 66, 93.66);
INSERT INTO commits_records (label, level, ratio) VALUES ('stable', 55, 11.08);
