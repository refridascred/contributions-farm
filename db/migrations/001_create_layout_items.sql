-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (weight, level, ratio) VALUES (62.33, 71, 38.24);
INSERT INTO layout_items (weight, level, ratio) VALUES (58.94, 81, 44.73);
