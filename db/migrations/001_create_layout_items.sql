-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (level, weight, score) VALUES (46, 67.29, 48.45);
INSERT INTO layout_items (level, weight, score) VALUES (35, 53.32, 20.95);
INSERT INTO layout_items (level, weight, score) VALUES (34, 63.18, 26.05);
