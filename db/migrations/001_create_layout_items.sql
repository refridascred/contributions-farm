-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, weight, ratio) VALUES (77, 56.46, 22.42);
INSERT INTO layout_items (level, weight, ratio) VALUES (82, 92.25, 76.17);
