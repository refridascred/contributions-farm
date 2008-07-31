-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (owner, level, ratio) VALUES ('standard', 0, 65.84);
INSERT INTO commits_records (owner, level, ratio) VALUES ('cached', 70, 95.82);
