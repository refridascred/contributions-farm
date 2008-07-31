-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (active, level, ratio) VALUES (39, 20, 4.09);
INSERT INTO commits_records (active, level, ratio) VALUES (40, 6, 60.61);
INSERT INTO commits_records (active, level, ratio) VALUES (17, 12, 33.18);
