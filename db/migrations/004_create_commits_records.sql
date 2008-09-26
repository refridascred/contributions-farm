-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, active, owner, level, ratio) VALUES ('fallback', 45, 'primary', 0, 10.19);
INSERT INTO commits_records (region, active, owner, level, ratio) VALUES ('cached', 64, 'strict', 78, 2.26);
INSERT INTO commits_records (region, active, owner, level, ratio) VALUES ('staging', 52, 'local', 34, 57.98);
