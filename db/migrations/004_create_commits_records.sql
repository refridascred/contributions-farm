-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    token TEXT,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (active, level, token, weight, owner) VALUES (70, 95, 'cached', 51.92, 'stable');
INSERT INTO commits_records (active, level, token, weight, owner) VALUES (68, 39, 'fallback', 4.2, 'stable');
INSERT INTO commits_records (active, level, token, weight, owner) VALUES (80, 78, 'eu-west', 64.68, 'legacy');
