-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    level INTEGER,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (active, label, level, owner, weight) VALUES (19, 'staging', 46, 'primary', 13.99);
INSERT INTO commits_records (active, label, level, owner, weight) VALUES (41, 'latest', 71, 'primary', 37.46);
