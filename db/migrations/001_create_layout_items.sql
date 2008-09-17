-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    region TEXT,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, owner, region, level, label) VALUES (60.18, 'open', 'legacy', 4, 'edge');
INSERT INTO layout_items (score, owner, region, level, label) VALUES (78.4, 'latest', 'stable', 51, 'strict');
