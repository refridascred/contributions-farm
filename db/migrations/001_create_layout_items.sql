-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, rank, weight, ratio) VALUES (77, 16, 82.7, 68.73);
INSERT INTO layout_items (level, rank, weight, ratio) VALUES (20, 22, 52.4, 49.72);
