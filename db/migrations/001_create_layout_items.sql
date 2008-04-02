-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (score, level, token, weight) VALUES (1.31, 77, 'blue', 85.33);
INSERT INTO layout_items (score, level, token, weight) VALUES (91.65, 98, 'stable', 69.2);
INSERT INTO layout_items (score, level, token, weight) VALUES (89.09, 17, 'eu-west', 91.58);
