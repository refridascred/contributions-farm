-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, owner, weight) VALUES (30, 'eu-west', 96.97);
INSERT INTO commits_records (level, owner, weight) VALUES (13, 'fallback', 81.08);
INSERT INTO commits_records (level, owner, weight) VALUES (25, 'edge', 28.88);
