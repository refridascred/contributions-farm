-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (weight, level, score) VALUES (48.6, 8, 64.8);
INSERT INTO layout_items (weight, level, score) VALUES (89.33, 78, 96.41);
INSERT INTO layout_items (weight, level, score) VALUES (11.03, 66, 86.71);
