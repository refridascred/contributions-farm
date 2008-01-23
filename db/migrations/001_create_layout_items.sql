-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (level, weight, ratio) VALUES (59, 3.67, 3.91);
INSERT INTO layout_items (level, weight, ratio) VALUES (4, 1.56, 23.31);
