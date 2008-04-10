-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (ratio, token, level) VALUES (84.28, 'strict', 52);
INSERT INTO layout_items (ratio, token, level) VALUES (8.81, 'legacy', 26);
INSERT INTO layout_items (ratio, token, level) VALUES (51.16, 'stable', 80);
