-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, count, owner) VALUES (63, 87, 'green');
INSERT INTO commits_records (level, count, owner) VALUES (71, 98, 'local');
INSERT INTO commits_records (level, count, owner) VALUES (41, 4, 'fallback');
