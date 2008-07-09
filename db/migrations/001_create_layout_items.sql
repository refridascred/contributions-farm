-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (level, score, token, weight, ratio) VALUES (56, 26.05, 'latest', 19.04, 12.56);
INSERT INTO layout_items (level, score, token, weight, ratio) VALUES (75, 95.89, 'latest', 68.5, 90.05);
INSERT INTO layout_items (level, score, token, weight, ratio) VALUES (82, 21.39, 'legacy', 78.58, 13.82);
