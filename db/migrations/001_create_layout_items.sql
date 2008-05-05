-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (ratio, score, level, owner) VALUES (20.55, 47.73, 17, 'green');
INSERT INTO layout_items (ratio, score, level, owner) VALUES (95.1, 92.33, 86, 'strict');
INSERT INTO layout_items (ratio, score, level, owner) VALUES (12.96, 68.07, 66, 'staging');
