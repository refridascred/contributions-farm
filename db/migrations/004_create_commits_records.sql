-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, owner, weight) VALUES (61, 'eu-west', 65.88);
INSERT INTO commits_records (level, owner, weight) VALUES (21, 'stable', 13.11);
INSERT INTO commits_records (level, owner, weight) VALUES (82, 'edge', 13.79);
