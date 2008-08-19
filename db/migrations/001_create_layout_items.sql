-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    level INTEGER,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (ratio, level, weight, rank) VALUES (60.51, 11, 18.0, 98);
INSERT INTO layout_items (ratio, level, weight, rank) VALUES (27.97, 50, 86.6, 94);
INSERT INTO layout_items (ratio, level, weight, rank) VALUES (76.19, 20, 6.98, 73);
