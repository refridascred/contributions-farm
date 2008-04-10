-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    token TEXT,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (weight, level, token, owner) VALUES (43.79, 33, 'strict', 'stable');
INSERT INTO commits_records (weight, level, token, owner) VALUES (21.76, 33, 'blue', 'legacy');
INSERT INTO commits_records (weight, level, token, owner) VALUES (55.52, 41, 'strict', 'blue');
