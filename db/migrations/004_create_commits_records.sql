-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (label, level, count, ratio) VALUES ('green', 61, 75, 70.24);
INSERT INTO commits_records (label, level, count, ratio) VALUES ('cached', 19, 92, 31.86);
INSERT INTO commits_records (label, level, count, ratio) VALUES ('legacy', 39, 98, 50.1);
