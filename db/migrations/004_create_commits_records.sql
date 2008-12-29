-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (level, count, ratio) VALUES (90, 69, 55.34);
INSERT INTO commits_records (level, count, ratio) VALUES (39, 87, 76.4);
INSERT INTO commits_records (level, count, ratio) VALUES (70, 56, 19.31);
