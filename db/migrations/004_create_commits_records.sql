-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (token, active, owner, weight, level) VALUES ('cached', 84, 'eu-west', 25.51, 19);
INSERT INTO commits_records (token, active, owner, weight, level) VALUES ('fallback', 2, 'legacy', 21.44, 74);
